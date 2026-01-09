using System;
using System.Data;
using System.Security.Cryptography;
using VRMS.Database;
using VRMS.Enums;
using VRMS.Models.Accounts;

namespace VRMS.Services;

public class UserService
{
    private const int SaltSize = 16;
    private const int KeySize = 32;
    private const int Iterations = 100_000;

    public int CreateUser(string username, string password, UserRole role, bool isActive)
    {
        var passwordHash = HashPassword(password);

        var result = DB.ExecuteScalar($"""
            CALL sp_users_create(
                '{username}',
                '{passwordHash}',
                '{role}',
                {isActive.ToString().ToLower()}
            );
        """);

        return Convert.ToInt32(result);
    }

    public User? GetById(int id)
    {
        var table = DB.ExecuteQuery($"CALL sp_users_get_by_id({id});");
        if (table.Rows.Count == 0)
            return null;

        return MapUser(table.Rows[0]);
    }

    public User? GetByUsername(string username)
    {
        var table = DB.ExecuteQuery($"CALL sp_users_get_by_username('{username}');");
        if (table.Rows.Count == 0)
            return null;

        return MapUser(table.Rows[0]);
    }

    public User? Authenticate(string username, string password)
    {
        var table = DB.ExecuteQuery($"CALL sp_users_authenticate('{username}');");
        if (table.Rows.Count == 0)
            return null;

        var row = table.Rows[0];
        var storedHash = row["password_hash"].ToString()!;

        if (!VerifyPassword(password, storedHash))
            return null;

        return MapUser(row);
    }

    public void Deactivate(int id)
    {
        DB.ExecuteNonQuery($"CALL sp_users_deactivate({id});");
    }

    private static string HashPassword(string password)
    {
        using var rng = RandomNumberGenerator.Create();
        var salt = new byte[SaltSize];
        rng.GetBytes(salt);

        using var pbkdf2 = new Rfc2898DeriveBytes(
            password,
            salt,
            Iterations,
            HashAlgorithmName.SHA256
        );

        var key = pbkdf2.GetBytes(KeySize);

        return $"{Iterations}.{Convert.ToBase64String(salt)}.{Convert.ToBase64String(key)}";
    }

    private static bool VerifyPassword(string password, string hash)
    {
        var parts = hash.Split('.');
        if (parts.Length != 3)
            return false;

        var iterations = Convert.ToInt32(parts[0]);
        var salt = Convert.FromBase64String(parts[1]);
        var storedKey = Convert.FromBase64String(parts[2]);

        using var pbkdf2 = new Rfc2898DeriveBytes(
            password,
            salt,
            iterations,
            HashAlgorithmName.SHA256
        );

        var computedKey = pbkdf2.GetBytes(storedKey.Length);
        return CryptographicOperations.FixedTimeEquals(computedKey, storedKey);
    }

    private static User MapUser(DataRow row)
    {
        var role = Enum.Parse<UserRole>(row["role"].ToString()!);

        User user = role switch
        {
            UserRole.Admin => new Admin(),
            UserRole.RentalAgent => new RentalAgent(),
            _ => throw new InvalidOperationException($"Unsupported role: {role}")
        };

        user.Id = Convert.ToInt32(row["id"]);
        user.Username = row["username"].ToString()!;
        user.PasswordHash = row["password_hash"].ToString()!;
        user.Role = role;
        user.IsActive = Convert.ToBoolean(row["is_active"]);

        return user;
    }
}
