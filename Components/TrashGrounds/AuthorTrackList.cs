using Microsoft.AspNetCore.Mvc;
using TrashGrounds.Models.Database;

namespace TrashGrounds.Components;

public class AuthorTrackList : ViewComponent
{
    public IViewComponentResult Invoke(User user) {
        return View("~/Views/Components/TrashGrounds/AuthorTrackList.cshtml", user);
    }
}
