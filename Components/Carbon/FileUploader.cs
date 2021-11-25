using Microsoft.AspNetCore.Mvc;

namespace TrashGrounds.Components;

public class FileUploader : ViewComponent
{
    public IViewComponentResult Invoke(string description = "", string label = "")
    {
        ViewBag.Description = description;
        ViewBag.Label = label;

        return View("~/Views/Components/Carbon/FileUploader.cshtml");
    }
}
