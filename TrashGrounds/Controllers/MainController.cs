using Microsoft.AspNetCore.Mvc;

namespace TrashGrounds.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}