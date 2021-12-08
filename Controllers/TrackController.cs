using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TrashGrounds.Controllers;

public class TrackController : Controller
{
    public IActionResult Index(int id)
    {
        return View("~/Views/Pages/Track/Index.cshtml", id);
    }

    public IActionResult New() {
        ViewBag.IsEditing = false;

        return View("~/Views/Pages/Track/Edit.cshtml");
    }

    public IActionResult Edit() {
        ViewBag.IsEditing = true;

        return View("~/Views/Pages/Track/Edit.cshtml");
    }
}
