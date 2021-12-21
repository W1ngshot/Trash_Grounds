using Microsoft.AspNetCore.Mvc;

namespace TrashGrounds.Components;

public class TextInput : ViewComponent
{
    public IViewComponentResult Invoke(string type = "text", string label = "", string className = "", string name = "", bool isLight = false)
    {
        ViewBag.Type = type;
        ViewBag.Label = label;
        ViewBag.ClassName = className;
        ViewBag.Name = name;
        ViewBag.IsLight = isLight;

        return View("~/Views/Components/Carbon/TextInput.cshtml");
    }
}
