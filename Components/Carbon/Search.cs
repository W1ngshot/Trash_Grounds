using Microsoft.AspNetCore.Mvc;

namespace TrashGrounds.Components;

public class Search : ViewComponent
{
    public IViewComponentResult Invoke(string placeholder = "Поиск", string className = "")
    {
        ViewBag.Placeholder = placeholder;
        ViewBag.ClassName = className;

        return View("~/Views/Components/Carbon/Search.cshtml");
    }
}