using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TrashGrounds.Models;

namespace TrashGrounds.Components
{
    public class Dropdown : ViewComponent
    {
        public IViewComponentResult Invoke(IEnumerable<DropdownOption> options, string label = "")
        {
            return View("~/Views/CarbonComponents/Dropdown.cshtml", new DropdownViewModel(label, options));
        }
    }
}