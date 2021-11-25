using Microsoft.AspNetCore.Mvc;

namespace TrashGrounds.Components;

public class Dropdown : ViewComponent
{
    public IViewComponentResult Invoke(string label = "")
    {
        return View("~/Views/Components/Carbon/Dropdown.cshtml", label);
    }
}
