using Microsoft.AspNetCore.Mvc;

namespace TrashGrounds.Components;

public class TextArea : ViewComponent
{
    public IViewComponentResult Invoke(string label = "", string placeholder = "", string className = "")
    {
        ViewBag.Label = label;
        ViewBag.Placeholder = placeholder;
        ViewBag.ClassName = className;
        
        return View("~/Views/Components/Carbon/TextArea.cshtml");
    }
}