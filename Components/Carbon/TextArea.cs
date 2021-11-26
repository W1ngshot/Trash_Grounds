using Microsoft.AspNetCore.Mvc;

namespace TrashGrounds.Components;

public class TextArea : ViewComponent
{
    public IViewComponentResult Invoke(string label = "", string placeholder = "")
    {
        ViewBag.Label = label;
        ViewBag.Placeholder = placeholder;
        
        return View("~/Views/Components/Carbon/TextArea.cshtml");
    }
}