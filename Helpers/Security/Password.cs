using System.Security.Cryptography;
using System.Text;

namespace VRMS.Helpers.Security;

public static class Password
{
    public static string Hash(string plainPassword)
    {
        if (string.IsNullOrWhiteSpace(plainPassword))
            throw new ArgumentException("Password cannot be empty.", nameof(plainPassword));

        using var sha = SHA256.Create();
        var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(plainPassword));
        return Convert.ToBase64String(bytes);
    }

    public static bool Verify(string plainPassword, string storedHash)
    {
        if (string.IsNullOrEmpty(storedHash))
            return false;

        return Hash(plainPassword) == storedHash;
    }
}
