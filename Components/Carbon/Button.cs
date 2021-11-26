using Microsoft.AspNetCore.Mvc;

namespace TrashGrounds.Components;

public class Button : ViewComponent
{
    public IViewComponentResult Invoke(string type = "primary", string text = "", string size = "large", string className = "")
    {
        ViewBag.Type = type;
        ViewBag.Size = size;
        ViewBag.Text = text;
        ViewBag.ClassName = className;

        return View("~/Views/Components/Carbon/Button.cshtml");
    }
}
