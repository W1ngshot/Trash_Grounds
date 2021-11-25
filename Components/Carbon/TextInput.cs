using Microsoft.AspNetCore.Mvc;

namespace TrashGrounds.Components;

public class TextInput : ViewComponent
{
    public IViewComponentResult Invoke(string type = "text", string label = "")
    {
        ViewBag.Type = type;
        ViewBag.Label = label;

        return View("~/Views/Components/Carbon/TextInput.cshtml");
    }
}
