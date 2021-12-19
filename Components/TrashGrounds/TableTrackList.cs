using Microsoft.AspNetCore.Mvc;
using TrashGrounds.Models;

namespace TrashGrounds.Components;

public class TableTrackList : ViewComponent
{
    public IViewComponentResult Invoke(IEnumerable<TrackCardModel>? tracks) {
        return View("~/Views/Components/TrashGrounds/TableTrackList.cshtml", tracks);
    }
}
