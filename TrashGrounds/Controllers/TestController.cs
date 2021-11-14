using Microsoft.AspNetCore.Mvc;

namespace TrashGrounds.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}