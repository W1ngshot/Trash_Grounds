using Microsoft.AspNetCore.Mvc;

namespace TrashGrounds.Components;

public class AuthorTrackList : ViewComponent
{
    public IViewComponentResult Invoke() {
        return View("~/Views/Components/TrashGrounds/AuthorTrackList.cshtml");
    }
}
