using Microsoft.AspNetCore.Mvc;

namespace TrashGrounds.Components;

public class TextInput : ViewComponent
{
    public IViewComponentResult Invoke(string type = "text", string label = "", string name = "")
    {
        ViewBag.Type = type;
        ViewBag.Label = label;
        ViewBag.Name = name;

        return View("~/Views/Components/Carbon/TextInput.cshtml");
    }
}
