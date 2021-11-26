using Microsoft.AspNetCore.Mvc;

namespace TrashGrounds.Components;

public class Comment : ViewComponent
{
    public IViewComponentResult Invoke(string? avatarUrl = null, string username = "Username", string content = "Comment body", DateTime timestamp = new DateTime())
    {
        var timestampUnixMilli = (timestamp.ToUniversalTime() - DateTime.UnixEpoch).Milliseconds;
        var secondsElapsed = (new DateTime() - timestamp).Seconds;

        //todo: correct conversion
        ViewBag.TimeSincePublish = $"{secondsElapsed} секунд назад";
        ViewBag.AvatarUrl = avatarUrl;
        ViewBag.Username = username;
        ViewBag.PublishTimestamp = timestampUnixMilli;
        ViewBag.Content = content;

        return View("~/Views/Components/TrashGrounds/Comment.cshtml");
    }
}
