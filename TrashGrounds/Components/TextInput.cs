using Microsoft.AspNetCore.Mvc;

namespace TrashGrounds.Components
{
    public class TextInput : ViewComponent
    {
        public IViewComponentResult Invoke(string type, string label)
        {
            return View(type, label);
        }
    }
}