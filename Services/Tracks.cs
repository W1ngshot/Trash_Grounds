using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TrashGrounds.Services.Database;
using TrashGrounds.Models.Database;
using TrashGrounds.Models;

namespace TrashGrounds.Services
{
    public class Tracks
    {
        public static void AddDataToDB()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                User wingshot = new User { Nickname = "Wingshot", Email = "k@mail.ru", Password = "s", Reg_date = DateTime.Now};
                var mashupGenre = new Genre {Name = "Mashup"};
                var tr1 = new Track { Title = "Всё будет под подошвой", Description = "туц туц туц", Genre = mashupGenre, User = wingshot, IsExplicit = false, Upload_Date = DateTime.Now};
                var tr2 = new Track { Title = "Черный бумер под подошвой", Description = "туц туц 2", Genre = mashupGenre, User = wingshot, IsExplicit = false, Upload_Date = DateTime.Now};
                var tr3 = new Track { Title = "Всё будет под подошвой", Description = "туц туц 3", Genre = mashupGenre, User = wingshot, IsExplicit = false, Upload_Date = DateTime.Now};
                db.Users.Add(wingshot);
                db.Genres.Add(mashupGenre);
                db.Tracks.Add(tr1);
                db.Tracks.Add(tr2);
                db.Tracks.Add(tr3);
                db.SaveChanges();
            }
        }
        
        private static double GetTrackRate(Track track)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var trackRates = db.Rates.Where(x => x.Track == track).ToList();
                var rate = 0.0;
                var ratesCount = trackRates.Count;
                if (ratesCount != 0)
                {
                    var ratesSum = trackRates.Sum(x => x.Rating);
                    rate = (double)ratesSum / ratesCount;
                    rate = Math.Round(rate, 1);
                }
                return rate;
            }
        }
        
        public void GetPopularTracks()
        {
            
        }

        public static IEnumerable<TrackCardModel> GetNewTracks()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var result = new List<TrackCardModel>();
                var tracks = db.Tracks.Include(t => t.User).OrderBy(track => track.Upload_Date).Take(6).ToList();
                foreach (var track in tracks)
                {
                    var rate = GetTrackRate(track);
                    var item = new TrackCardModel { TrackId = track.Id, TrackName = track.Title, AuthorName = track.User.Nickname, AuthorId = track.User.Id, Rating = rate, PreviewUrl = $@"/assets/img/{track.Id}.jpg"};
                    result.Add(item);
                }
                return result;
            }
        }

        public void GetTrendingTracks()
        {
            
        }
    }
}