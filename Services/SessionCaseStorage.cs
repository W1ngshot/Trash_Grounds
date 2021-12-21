using TrashGrounds.Models.Database;
using TrashGrounds.Services.Database;

namespace TrashGrounds.Services;

public static class SessionCaseStorage
{
    private static HashSet<string> keys = new HashSet<string>();
    private static Dictionary<string, DateTime> keysExpireDates = new Dictionary<string, DateTime>();
    private static Dictionary<string, int> keysOwnersIds = new Dictionary<string, int>();

    public static void AddNewSession(string key, int userId)
    {
        keys.Add(key);
        keysExpireDates.Add(key, DateTime.Now.AddDays(1));
        keysOwnersIds.Add(key, userId);
    }

    public static User? GetUserByKey(string key)
    {
        using ApplicationContext db = new ApplicationContext();
        if (keys.Contains(key) && keysExpireDates[key] < DateTime.Now)
        {
            var userId = keysOwnersIds[key];
            return db.Users.FirstOrDefault(user => user.Id == userId);
        }
        return null;
    }
}