using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using VRMS.Database;
using VRMS.Database.DBHelpers.SqlEscape;
using VRMS.Enums;
using VRMS.Models.Accounts;

namespace VRMS.Services;

public class UserService
{
    // ----------------------------
    // AUTHENTICATION
    // ----------------------------

    public User Authenticate(string username, string plainPassword)
    {
        var table = DB.ExecuteQuery(
            $"CALL sp_users_authenticate('{Sql.Esc(username)}');"
        );

        if (table.Rows.Count == 0)
            throw new InvalidOperationException("Invalid username or inactive account.");

        var row = table.Rows[0];
        var storedHash = row["password_hash"].ToString()!;

        if (!VerifyPassword(plainPassword, storedHash))
            throw new InvalidOperationException("Invalid password.");

        return MaterializeUser(row);
    }

    // ----------------------------
    // CREATE USER
    // ----------------------------

    public int CreateUser(
        string username,
        string plainPassword,
        UserRole role,
        bool isActive = true
    )
    {
        var hash = HashPassword(plainPassword);

        var result = DB.ExecuteQuery(
            $"CALL sp_users_create(" +
            $"'{Sql.Esc(username)}'," +
            $"'{Sql.Esc(hash)}'," +
            $"'{role}'," +
            $"{(isActive ? "TRUE" : "FALSE")}" +
            $");"
        );

        return Convert.ToInt32(result.Rows[0]["user_id"]);
    }

    // ----------------------------
    // LOOKUPS
    // ----------------------------

    public User GetById(int userId)
    {
        var table = DB.ExecuteQuery(
            $"CALL sp_users_get_by_id({userId});"
        );

        if (table.Rows.Count == 0)
            throw new InvalidOperationException("User not found.");

        return MaterializeUser(table.Rows[0]);
    }

    public User GetByUsername(string username)
    {
        var table = DB.ExecuteQuery(
            $"CALL sp_users_get_by_username('{Sql.Esc(username)}');"
        );

        if (table.Rows.Count == 0)
            throw new InvalidOperationException("User not found.");

        return MaterializeUser(table.Rows[0]);
    }

    // ----------------------------
    // DEACTIVATE
    // ----------------------------

    public void Deactivate(int userId)
    {
        DB.ExecuteNonQuery(
            $"CALL sp_users_deactivate({userId});"
        );
    }

    // ----------------------------
    // INTERNAL HELPERS
    // ----------------------------

    private static User MaterializeUser(DataRow row)
    {
        var role = Enum.Parse<UserRole>(row["role"].ToString()!, true);

        User user = role switch
        {
            UserRole.Admin => new Admin(),
            UserRole.RentalAgent => new RentalAgent(),
            _ => throw new InvalidOperationException("Unknown user role.")
        };

        user.Id = Convert.ToInt32(row["id"]);
        user.Username = row["username"].ToString()!;
        user.PasswordHash = row["password_hash"].ToString()!;
        user.Role = role;
        user.IsActive = Convert.ToBoolean(row["is_active"]);

        return user;
    }

    // ----------------------------
    // PASSWORD SECURITY
    // ----------------------------

    private static string HashPassword(string password)
    {
        using var sha = SHA256.Create();
        var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
        return Convert.ToBase64String(bytes);
    }

    private static bool VerifyPassword(string plain, string hash)
    {
        return HashPassword(plain) == hash;
    }
    
}
