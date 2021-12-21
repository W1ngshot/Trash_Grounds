using System.Security.Cryptography;
using Konscious.Security.Cryptography;
using System.Text;

namespace TrashGrounds.Utils;

public static class Cryptography {
  public static List<byte> HashPassword(string password)
    {
        var passwordBytes = Encoding.UTF8.GetBytes(password);
        var hasher = new Argon2i(passwordBytes) {
            DegreeOfParallelism = 1,
            MemorySize = 2048,
            Iterations = 1
        };
        return hasher.GetBytes(32).ToList();
    }

    public static string GetRandomKey()
    {
        var randomBytes = RandomNumberGenerator.GetBytes(32);
        return Convert.ToBase64String(randomBytes);
    }
}