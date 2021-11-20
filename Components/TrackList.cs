using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TrashGrounds.Models;

namespace TrashGrounds.Components
{
    public class TrackList : ViewComponent
    {
        public IViewComponentResult Invoke(string name, string iconPath, IEnumerable<TrackCardModel> tracks)
        {
            ViewBag.Name = name;
            ViewBag.IconPath = iconPath;
            ViewBag.Tracks = tracks.Take(6);

            return View("~/Views/Shared/Components/TrackList.cshtml");
        }
    }
}