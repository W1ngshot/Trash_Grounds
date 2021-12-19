using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
using TrashGrounds.Models;
using Konscious.Security.Cryptography;
using System.Text;
using TrashGrounds.Models.Database;
using TrashGrounds.Services;
using TrashGrounds.Services.Database;

namespace TrashGrounds.Controllers;
public class AuthController : Controller
{
    public IActionResult SignIn(string errorMsg = "")
    {
        return View("~/Views/Pages/Auth/SignIn.cshtml");
    }
    
    public IActionResult SignUp()
    {
        return View("~/Views/Pages/Auth/SignUp.cshtml");
    }

    private List<byte> HashPassword(string password)
    {
        var passwordBytes = Encoding.UTF8.GetBytes(password);
        var hasher = new Argon2i(passwordBytes) {
            DegreeOfParallelism = 1,
            MemorySize = 2048,
            Iterations = 1
        };
        return hasher.GetBytes(32).ToList();
    }

    private string GetRandomKey()
    {
        var randomBytes = RandomNumberGenerator.GetBytes(32);
        return Convert.ToBase64String(randomBytes);
    }

    [HttpPost]
    public IActionResult SignIn(SignInRequestPayload payload)
    {
        using ApplicationContext db = new ApplicationContext();
        var hashedPassword = HashPassword(payload.Password);
        var user = db.Users.FirstOrDefault(u => u.Nickname == payload.Login);
        if (user is null || user.PasswordBytes != hashedPassword)
            return SignIn("Неправильное имя пользователя или пароль");
        var key = GetRandomKey();
        Response.Cookies.Append("auth", key, new CookieOptions { IsEssential = true, Secure = true });
        SessionCaseStorage.AddNewSession(key, user.Id);
        return Redirect("/");
    }
    
    [HttpPost]
    public IActionResult SignUp(SignUpRequestPayload payload)
    {
        using ApplicationContext db = new ApplicationContext();
        var hashedPassword = HashPassword(payload.Password);
        var newUser = new User { Nickname = payload.Login, Email = payload.Email, PasswordBytes = hashedPassword, Reg_date = DateTime.Now};
        db.Users.Add(newUser);
        db.SaveChanges();
        var key = GetRandomKey();
        Response.Cookies.Append("auth", key, new CookieOptions { IsEssential = true, Secure = true });
        SessionCaseStorage.AddNewSession(key, db.Users.FirstOrDefault(u => u.Nickname == payload.Login)!.Id);
        return Redirect("/");
    }
}