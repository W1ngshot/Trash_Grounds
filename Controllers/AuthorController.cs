using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TrashGrounds.Controllers;

public class AuthorController : Controller
{
    public IActionResult Index() => Tracks();
    public IActionResult Tracks()
    {
        return View("~/Views/Pages/Author.cshtml");
    }
}
