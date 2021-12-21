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

    public static int? GetUserByKey(string key)
    {
        if (!keys.Contains(key) && keysExpireDates[key] >= DateTime.Now)
            return null;
        return keysOwnersIds[key];
    }
}