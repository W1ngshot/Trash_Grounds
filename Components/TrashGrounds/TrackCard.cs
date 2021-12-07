using System;
using Microsoft.AspNetCore.Mvc;

namespace TrashGrounds.Components;

public class TrackCard : ViewComponent
{
    public IViewComponentResult Invoke(
        double? rating = null,
        string? previewUrl = null,
        long trackId = 0,
        string trackName = "Track name",
        long authorId = 0,
        string authorName = "Author name")
    {
        ViewBag.TrackId = trackId;
        ViewBag.TrackName = trackName;
        ViewBag.AuthorId = authorId;
        ViewBag.AuthorName = authorName;
        ViewBag.PreviewUrl = previewUrl;

        if (rating != null)
            ViewBag.Rating = String.Format("{0:0.0}", rating);

        return View("~/Views/Components/TrashGrounds/TrackCard.cshtml");
    }
}
