namespace TrashGrounds.Services;

public static class SessionCaseStorage
{
    private static HashSet<string> keys;
    private static Dictionary<string, DateTime> keysExpireDates;
    private static Dictionary<string, int> keysOwnersIds;

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