using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TrashGrounds.Controllers;

public class AuthorController : Controller
{
    public IActionResult Index(int id) => Tracks(id);
    public IActionResult Tracks(int id)
    {
        return View("~/Views/Pages/Author.cshtml", id);
    }
}
