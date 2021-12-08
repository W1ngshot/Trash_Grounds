using Microsoft.AspNetCore.Mvc;

namespace TrashGrounds.Components;

public class TextInput : ViewComponent
{
    public IViewComponentResult Invoke(string type = "text", string label = "", string className = "")
    {
        ViewBag.Type = type;
        ViewBag.Label = label;
        ViewBag.ClassName = className;

        return View("~/Views/Components/Carbon/TextInput.cshtml");
    }
}
