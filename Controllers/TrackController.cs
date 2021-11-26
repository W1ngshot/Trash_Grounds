using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TrashGrounds.Controllers;

public class TrackController : Controller
{
    public IActionResult Index()
    {
        return View("~/Views/Pages/Track.cshtml");
    }
}
