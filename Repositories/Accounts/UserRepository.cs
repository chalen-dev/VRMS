using System;
using System.Data;
using VRMS.Database;
using VRMS.Enums;
using VRMS.Models.Accounts;

namespace VRMS.Repositories.Accounts;

public class UserRepository
{
    // ----------------------------
    // CREATE
    // ----------------------------

    public int Create(
        string username,
        string passwordHash,
        UserRole role,
        bool isActive,
        string? photoPath)
    {
        var table = DB.Query(
            "CALL sp_users_create(@username,@password_hash,@role,@active,@photo);",
            ("@username", username),
            ("@password_hash", passwordHash),
            ("@role", role.ToString()),
            ("@active", isActive),
            ("@photo", photoPath)
        );

        if (table.Rows.Count == 0)
            throw new InvalidOperationException("Failed to create user.");

        return Convert.ToInt32(table.Rows[0]["id"]);
    }


    // ----------------------------
    // READ
    // ----------------------------

    public User GetById(int id)
    {
        var table = DB.Query(
            "CALL sp_users_get_by_id(@id);",
            ("@id", id)
        );

        if (table.Rows.Count == 0)
            throw new InvalidOperationException("User not found.");

        return Map(table.Rows[0]);
    }

    public User GetByUsername(string username)
    {
        var table = DB.Query(
            "CALL sp_users_get_by_username(@username);",
            ("@username", username)
        );

        if (table.Rows.Count == 0)
            throw new InvalidOperationException("User not found.");

        return Map(table.Rows[0]);
    }

    public User GetForAuthentication(string username)
    {
        var table = DB.Query(
            "CALL sp_users_authenticate(@username);",
            ("@username", username)
        );

        if (table.Rows.Count == 0)
            throw new InvalidOperationException(
                "Invalid username or inactive account.");

        return Map(table.Rows[0]);
    }

    // ----------------------------
    // UPDATE
    // ----------------------------

    public void UpdatePassword(int id, string passwordHash)
    {
        DB.Execute(
            "CALL sp_users_update_password(@id,@password_hash);",
            ("@id", id),
            ("@password_hash", passwordHash)
        );
    }

    public void UpdateProfile(
        int id,
        string username,
        UserRole role,
        bool isActive)
    {
        DB.Execute(
            "CALL sp_users_update_profile(@id,@username,@role,@active);",
            ("@id", id),
            ("@username", username),
            ("@role", role.ToString()),
            ("@active", isActive)
        );
    }

    public void Deactivate(int id)
    {
        DB.Execute(
            "CALL sp_users_deactivate(@id);",
            ("@id", id)
        );
    }
    
    public void UpdatePhoto(int userId, string photoPath)
    {
        DB.Execute(
            "CALL sp_users_update_photo(@id,@photo);",
            ("@id", userId),
            ("@photo", photoPath)
        );
    }


    // ----------------------------
    // MAPPING
    // ----------------------------

    private static User Map(DataRow row)
    {
        var role = Enum.Parse<UserRole>(
            row["role"].ToString()!, true);

        User user = role switch
        {
            UserRole.Admin => new Admin(),
            UserRole.RentalAgent => new RentalAgent(),
            _ => throw new InvalidOperationException(
                $"Unsupported user role: {role}")
        };

        user.Id = Convert.ToInt32(row["id"]);
        user.Username = row["username"].ToString()!;
        user.PasswordHash = row["password_hash"].ToString()!;
        user.Role = role;
        user.IsActive = Convert.ToBoolean(row["is_active"]);
        user.PhotoPath =
            row["photo_path"] == DBNull.Value
                ? null
                : row["photo_path"].ToString();

        return user;
    }
}
