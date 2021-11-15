using Microsoft.AspNetCore.Mvc;
using TrashGrounds.Models;
using System;

namespace TrashGrounds.Components
{

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
            var model = new TrackCardViewModel
            {
                TrackId = trackId,
                TrackName = trackName,
                AuthorId = authorId,
                AuthorName = authorName,
                PreviewUrl = previewUrl
            };

            if (rating != null)
                model.Rating = String.Format("{0:0.0}", rating);


            return View(model);
        }
    }
}