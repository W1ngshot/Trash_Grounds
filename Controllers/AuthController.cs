using Microsoft.AspNetCore.Mvc;

namespace TrashGrounds.Controllers;
public class AuthController : Controller
{
    public IActionResult SignIn()
    {
        return View("~/Views/Pages/Auth/SignIn.cshtml");
    }
    
    public IActionResult SignUp()
    {
        return View("~/Views/Pages/Auth/SignUp.cshtml");
    }
}