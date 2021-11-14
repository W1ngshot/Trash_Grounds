using Microsoft.AspNetCore.Mvc;

namespace TrashGrounds.Components
{
    public class Header : ViewComponent
    {
        public IViewComponentResult Invoke(bool isLogined)
        {
            return View(isLogined);
        }
    }
}