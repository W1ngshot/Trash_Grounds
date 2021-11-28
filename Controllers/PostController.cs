using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TrashGrounds.Controllers;

public class PostController : Controller
{
    public IActionResult New()
    {
        ViewBag.IsEditing = false;

        return View("~/Views/Pages/Post.cshtml");
    }

    public IActionResult Edit() 
    {
        ViewBag.IsEditing = true;

        return View("~/Views/Pages/Post.cshtml");
    }
}
