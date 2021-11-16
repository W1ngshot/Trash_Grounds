using Microsoft.AspNetCore.Mvc;

namespace TrashGrounds.Components
{
    public class TextArea : ViewComponent
    {
        public IViewComponentResult Invoke(string label)
        {
            return View("~/Views/CarbonComponents/TextArea.cshtml", label);
        }
    }
}