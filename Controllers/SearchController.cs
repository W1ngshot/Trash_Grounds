using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TrashGrounds.Controllers;

public class SearchController : Controller
{
    public IActionResult Index()
    {
        return View("~/Views/Pages/Search.cshtml");
    }
}
