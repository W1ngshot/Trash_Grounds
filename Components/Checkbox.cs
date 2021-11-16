using Microsoft.AspNetCore.Mvc;

namespace TrashGrounds.Components
{
    public class Checkbox : ViewComponent
    {
        public IViewComponentResult Invoke(string label)
        {
            return View("~/Views/CarbonComponents/Checkbox.cshtml", label);
        }
    }
}