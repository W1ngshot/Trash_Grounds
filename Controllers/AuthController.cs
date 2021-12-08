using Microsoft.AspNetCore.Mvc;
using TrashGrounds.Models;
using Konscious.Security.Cryptography;
using System.Text;

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

    [HttpPost]
    public IActionResult SignIn(SignInRequestPayload payload) {
        var passwordBytes = Encoding.UTF8.GetBytes(payload.Password);
        var hasher = new Argon2i(passwordBytes) {
            DegreeOfParallelism = 1,
            MemorySize = 2048,
            Iterations = 1
        };
        var hashedPassword = hasher.GetBytes(32);

        return Redirect("/");
    }
}