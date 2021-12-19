using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TrashGrounds.Controllers;

public class AccountController : Controller
{
    public IActionResult Index()
    {
        return View("~/Views/Pages/Account.cshtml");
    }
}
