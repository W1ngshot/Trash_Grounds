using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TrashGrounds.Controllers;

public class AdminController : Controller
{
    public IActionResult Index()
    {
        return View("~/Views/Pages/Admin.cshtml");
    }
}
