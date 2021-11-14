using Microsoft.AspNetCore.Mvc;
using TrashGrounds.Models;

namespace TrashGrounds.Components
{
    public class TextInput : ViewComponent
    {
        public IViewComponentResult Invoke(string type = "text", string label = "")
        {
            return View("~/Views/CarbonComponents/TextInput.cshtml", new TextInputViewModel(type, label));
        }
    }
}