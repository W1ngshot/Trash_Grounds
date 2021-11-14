using Microsoft.AspNetCore.Mvc;

namespace TrashGrounds.Components
{
    public class Button : ViewComponent
    {
        public IViewComponentResult Invoke(string type, string text)
        {
            return View(type, text);
        }
    }
}