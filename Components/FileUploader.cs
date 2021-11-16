using Microsoft.AspNetCore.Mvc;
using TrashGrounds.Models;

namespace TrashGrounds.Components
{
    public class FileUploader : ViewComponent
    {
        public IViewComponentResult Invoke(string description = "", string label = "")
        {
            return View("~/Views/CarbonComponents/FileUploader.cshtml", new FileUploaderViewModel(label, description));
        }
    }
}