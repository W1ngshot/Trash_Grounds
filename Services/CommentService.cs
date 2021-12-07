using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TrashGrounds.Services.Database;
using TrashGrounds.Models.Database;
using TrashGrounds.Models;

namespace TrashGrounds.Services;
public static class Comments
{

    public static IEnumerable<Comment> GetTrackComments(int trackId)
    {
        using ApplicationContext db = new ApplicationContext();
        var comments = db.Comments
            .Include(c => c.User)
            .Where(c => c.TrackId == trackId)
            .ToList();
        return comments;
    }
}