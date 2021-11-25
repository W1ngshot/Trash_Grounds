using Microsoft.AspNetCore.Mvc;

namespace TrashGrounds.Components;

public class Button : ViewComponent
{
    public IViewComponentResult Invoke(string type = "primary", string text = "", string size = "large")
    {
        ViewBag.Type = type;
        ViewBag.Size = size;
        ViewBag.Text = text;

        return View("~/Views/Components/Carbon/Button.cshtml");
    }
}
