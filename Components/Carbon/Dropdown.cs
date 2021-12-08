using Microsoft.AspNetCore.Mvc;

namespace TrashGrounds.Components;

public class Dropdown : ViewComponent
{
    public IViewComponentResult Invoke(string label = "", string className = "")
    {
        ViewBag.Label = label;
        ViewBag.ClassName = className;

        return View("~/Views/Components/Carbon/Dropdown.cshtml");
    }
}
