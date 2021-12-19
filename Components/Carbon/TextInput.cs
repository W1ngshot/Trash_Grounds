using Microsoft.AspNetCore.Mvc;

namespace TrashGrounds.Components;

public class TextInput : ViewComponent
{
    public IViewComponentResult Invoke(string type = "text", string label = "", string className = "", bool isLight = false)
    {
        ViewBag.Type = type;
        ViewBag.Label = label;
        ViewBag.ClassName = className;
        ViewBag.IsLight = isLight;

        return View("~/Views/Components/Carbon/TextInput.cshtml");
    }
}
