using Microsoft.AspNetCore.Mvc;

namespace TrashGrounds.Components;

public class Button : ViewComponent
{
    public IViewComponentResult Invoke(string style = "primary", string text = "", string size = "large", string className = "", string type = "button")
    {
        ViewBag.Style = style;
        ViewBag.Size = size;
        ViewBag.Text = text;
        ViewBag.ClassName = className;
        ViewBag.Type = type;

        return View("~/Views/Components/Carbon/Button.cshtml");
    }
}
