using Microsoft.AspNetCore.Mvc;

namespace TrashGrounds.Components;

public class Checkbox : ViewComponent
{
    public IViewComponentResult Invoke(string label)
    {
        return View("~/Views/Components/Carbon/Checkbox.cshtml", label);
    }
}