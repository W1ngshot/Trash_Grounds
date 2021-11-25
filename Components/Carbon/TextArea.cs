using Microsoft.AspNetCore.Mvc;

namespace TrashGrounds.Components;

public class TextArea : ViewComponent
{
    public IViewComponentResult Invoke(string label)
    {
        return View("~/Views/Components/Carbon/TextArea.cshtml", label);
    }
}