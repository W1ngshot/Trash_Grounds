using Microsoft.AspNetCore.Mvc;
using TrashGrounds.Models;

namespace TrashGrounds.Components
{
    public class Button : ViewComponent
    {
        public IViewComponentResult Invoke(string type = "primary", string text = "", string size = "large")
        {
            return View("~/Views/CarbonComponents/Button.cshtml", new ButtonViewModel(type, text, size));
        }
    }
}