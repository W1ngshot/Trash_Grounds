using Microsoft.AspNetCore.Mvc;

namespace TrashGrounds.Components;

public class Dropdown : ViewComponent
{
    public IViewComponentResult Invoke(string label = "", string className = "", bool isLight = false)
    {
        ViewBag.Label = label;
        ViewBag.ClassName = className;
        ViewBag.IsLight = isLight;

        return View("~/Views/Components/Carbon/Dropdown.cshtml");
    }
}
