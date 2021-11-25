using Microsoft.AspNetCore.Mvc;

namespace TrashGrounds.Components;

public class Header : ViewComponent
{
    public IViewComponentResult Invoke(bool isLogined = false)
    {
        return View("~/Views/Components/TrashGrounds/Header.cshtml", isLogined);
    }
}
