using Microsoft.AspNetCore.Mvc;

namespace TrashGrounds.Components
{
    public class Checkbox : ViewComponent
    {
        public IViewComponentResult Invoke(string label, string type = "checkbox")
        {
            return View(type, label);
        }
    }
}