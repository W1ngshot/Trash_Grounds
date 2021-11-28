using Microsoft.AspNetCore.Mvc;

namespace TrashGrounds.Components;

public class Post : ViewComponent
{
    public IViewComponentResult Invoke(string className) {
        ViewBag.ClassName = className;
        
        return View("~/Views/Components/TrashGrounds/Post.cshtml");
    }
}
