using System;
using System.IO;
using VRMS.Enums;
using VRMS.Helpers.Security;
using VRMS.Helpers.Storage;
using VRMS.Models.Accounts;
using VRMS.Repositories.Accounts;

namespace VRMS.Services.Account;

/// <summary>
/// Provides business logic for user authentication,
/// account lifecycle management, and profile maintenance.
///
/// This service acts as the single authority for:
/// - Authentication & password validation
/// - User creation and deactivation
/// - Password changes
/// - Profile and role updates
/// - User photo storage and lifecycle management
/// </summary>
public class UserService
{
    // ----------------------------
    // CONSTANTS
    // ----------------------------

    private const string UserPhotoFolder = "Users";
    private const string UserPhotoFileName = "profile";

    private const string DefaultUserPhotoPath =
        "Assets/profile_img.png";

    // ----------------------------
    // REPOSITORY
    // ----------------------------

    private readonly UserRepository _userRepo;

    // ----------------------------
    // INIT
    // ----------------------------

    public UserService(UserRepository userRepo)
    {
        _userRepo = userRepo;
    }

    // ----------------------------
    // AUTHENTICATION
    // ----------------------------

    public User Authenticate(
        string username,
        string plainPassword)
    {
        var user =
            _userRepo.GetForAuthentication(username);

        if (!Password.Verify(
                plainPassword,
                user.PasswordHash))
            throw new InvalidOperationException(
                "Invalid password.");

        user.PhotoPath =
            ResolvePhoto(user.PhotoPath);

        return user;
    }

    // ----------------------------
    // CREATE USER
    // ----------------------------

    public int CreateUser(
        string username,
        string plainPassword,
        UserRole role,
        bool isActive = true)
    {
        if (string.IsNullOrWhiteSpace(username))
            throw new InvalidOperationException(
                "Username cannot be empty.");

        var hash =
            Password.Hash(plainPassword);

        // User starts with NO uploaded photo
        return _userRepo.Create(
            username,
            hash,
            role,
            isActive,
            null);
    }

    // ----------------------------
    // LOOKUPS
    // ----------------------------

    public User GetById(int userId)
    {
        var user =
            _userRepo.GetById(userId);

        user.PhotoPath =
            ResolvePhoto(user.PhotoPath);

        return user;
    }

    public User GetByUsername(string username)
    {
        var user =
            _userRepo.GetByUsername(username);

        user.PhotoPath =
            ResolvePhoto(user.PhotoPath);

        return user;
    }

    // ----------------------------
    // DEACTIVATE
    // ----------------------------

    public void Deactivate(int userId)
        => _userRepo.Deactivate(userId);

    // ----------------------------
    // PASSWORD MANAGEMENT
    // ----------------------------

    public void ChangePassword(
        int userId,
        string currentPlainPassword,
        string newPlainPassword)
    {
        var user =
            _userRepo.GetById(userId);

        if (!Password.Verify(
                currentPlainPassword,
                user.PasswordHash))
            throw new InvalidOperationException(
                "Current password is incorrect.");

        var newHash =
            Password.Hash(newPlainPassword);

        _userRepo.UpdatePassword(
            userId,
            newHash);
    }

    // ----------------------------
    // PROFILE MANAGEMENT
    // ----------------------------

    public void UpdateUserProfile(
        int userId,
        string username,
        UserRole role,
        bool isActive)
    {
        if (string.IsNullOrWhiteSpace(username))
            throw new InvalidOperationException(
                "Username cannot be empty.");

        _userRepo.UpdateProfile(
            userId,
            username,
            role,
            isActive);
    }

    // ----------------------------
    // USER PHOTO MANAGEMENT
    // ----------------------------

    public void SetUserPhoto(
        int userId,
        Stream photoStream,
        string originalFileName)
    {
        var relativePath =
            FileStorageHelper.SaveSingleFile(
                photoStream,
                originalFileName,
                Path.Combine(
                    UserPhotoFolder,
                    userId.ToString()
                ),
                UserPhotoFileName,
                clearDirectoryFirst: true
            );

        _userRepo.UpdatePhoto(
            userId,
            relativePath);
    }

    public void DeleteUserPhoto(int userId)
    {
        FileStorageHelper.DeleteDirectory(
            Path.Combine(
                UserPhotoFolder,
                userId.ToString()
            )
        );

        _userRepo.UpdatePhoto(
            userId,
            null);
    }

    // ----------------------------
    // HELPERS
    // ----------------------------

    private static string ResolvePhoto(string? path)
        => string.IsNullOrWhiteSpace(path)
            ? DefaultUserPhotoPath
            : path;
}
