using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TrashGrounds.Services.Database;
using TrashGrounds.Models.Database;
using TrashGrounds.Models;

namespace TrashGrounds.Services
{
    public static class Tracks
    {
        /* DB helpers
        public static void AddDataToDB()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                User wingshot = new User { Nickname = "Wingshot", Email = "k@mail.ru", Password = "s", Reg_date = DateTime.Now};
                var mashupGenre = new Genre {Name = "Mashup"};
                var tr1 = new Track { Title = "Всё будет под подошвой", Description = "туц туц туц", Genre = mashupGenre, User = wingshot, IsExplicit = false, Upload_Date = DateTime.Now};
                var tr2 = new Track { Title = "Черный бумер под подошвой", Description = "туц туц 2", Genre = mashupGenre, User = wingshot, IsExplicit = false, Upload_Date = DateTime.Now};
                var tr3 = new Track { Title = "Oxxxy и Слава КПСС записали фит", Description = "туц туц 3", Genre = mashupGenre, User = wingshot, IsExplicit = false, Upload_Date = DateTime.Now};
                db.Users.Add(wingshot);
                db.Genres.Add(mashupGenre);
                db.Tracks.Add(tr1);
                db.Tracks.Add(tr2);
                db.Tracks.Add(tr3);
                db.SaveChanges();
            }
        }

        public static void AddRatesToDB()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var rate1 = new Rate {Track = db.Tracks.Find(3), Date = DateTime.Now, UserId = 1, Rating = 5};
                var rate2 = new Rate {Track = db.Tracks.Find(1), Date = DateTime.Now, UserId = 1, Rating = 4};
                var rate3 = new Rate {Track = db.Tracks.Find(2), Date = DateTime.Now, UserId = 1, Rating = 3};
                db.Rates.AddRange(rate1, rate2, rate3);
                db.SaveChanges();
            }
        }

        public static void AddListensToDB(int trackId, int listensToAdd)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Tracks.Find(trackId).Listens_Count += listensToAdd;
                db.SaveChanges();
                Console.WriteLine(db.Tracks.Find(trackId).Listens_Count);
            }
        }

        public static void AddNewUserAndRates()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                User somebody = new User { Nickname = "Somebody", Email = "once@told.me", Password = "the world is gonna roll me", Reg_date = DateTime.Now};
                db.Users.Add(somebody);
                db.SaveChanges();
                var rate1 = new Rate {TrackId = 3, Date = DateTime.Now, User = somebody, Rating = 4};
                var rate3 = new Rate {TrackId = 2, Date = DateTime.Now, User = somebody, Rating = 4};
                db.Rates.AddRange(rate1, rate3);
                db.SaveChanges();
            }
        }

        public static void AddAnotherRateToDB()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var rate2 = new Rate {TrackId = 1, Date = DateTime.Now, UserId = 2, Rating = 4};
                var rate3 = new Rate {TrackId = 1, Date = DateTime.Now, UserId = 2, Rating = 4};
                db.Rates.AddRange(rate2, rate3);
                db.SaveChanges();
            }
        } 

        public static void AddNewTracksToDB()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var tr4 = new Track
                {
                    Title = "Чёрный Bangarang", Description = "Нереальный развал кабин", GenreId = 1, UserId = 1,
                    IsExplicit = false, Upload_Date = DateTime.Now
                };
                var tr5 = new Track
                {
                    Title = "Гонщик нелегальный едет под евробит", Description = "евробит = +100 к скорости",
                    GenreId = 1, UserId = 1, IsExplicit = false, Upload_Date = DateTime.Now
                };
                var tr6 = new Track
                {
                    Title = "1Kla$ на рукаве", Description = "Цой и 1Kla$", GenreId = 1, UserId = 1, IsExplicit = false,
                    Upload_Date = DateTime.Now
                };
                db.Tracks.AddRange(tr4, tr5, tr6);
                db.SaveChanges();
            }
        }
        */
        public static Tuple<double, int> GetTrackRateAndCount(this Track track)
        {
            using ApplicationContext db = new ApplicationContext();
            var trackRates = db.Rates
                .Include(r => r.Track)
                .Where(x => x.Track == track)
                .ToList();
            var rate = 0.0;
            var ratesCount = trackRates.Count;
            if (ratesCount != 0)
            {
                var ratesSum = trackRates.Sum(x => x.Rating);
                rate = (double)ratesSum / ratesCount;
                rate = Math.Round(rate, 1);
            }
            return new Tuple<double, int>(rate, trackRates.Count);
        }
        
        private static double GetTrackRate(this Track track)
        {
            using ApplicationContext db = new ApplicationContext();
            var trackRates = db.Rates
                .Include(r => r.Track)
                .Where(x => x.Track == track)
                .ToList();
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
        
        private static double GetTrackPopularity(this Track track)
        {
            using ApplicationContext db = new ApplicationContext();
            var trackRates = db.Rates
                .Include(r => r.Track)
                .Where(x => x.Track == track)
                .ToList();
            var trackPopularity = 0.0;
            var ratesCount = trackRates.Count;
            if (ratesCount != 0)
            {
                var ratesSum = trackRates.Sum(x => x.Rating);
                trackPopularity = (double)ratesSum / ratesCount;
                trackPopularity *= Math.Log10(ratesCount);
            }
            return trackPopularity;
        }
        
        private static int GetNumberOfRatesLastWeek(this Track track)
        {
            using ApplicationContext db = new ApplicationContext();
            const int secondsInWeek = 604800;
            var ratesCount = db.Rates
                .Include(r => r.Track)
                .Where(r => r.Track == track)
                .ToList()
                .Where(r => DateTime.Now.Subtract(r.Date).TotalSeconds <= secondsInWeek)
                .ToList();
            return ratesCount.Count;
        }

        private static IEnumerable<TrackCardModel> CreateCardModels(List<Track> tracks)
        {
            var result = new List<TrackCardModel>();
            foreach (var track in tracks)
            {
                var rate = GetTrackRate(track);
                var item = new TrackCardModel { TrackId = track.Id, TrackName = track.Title, AuthorName = track.User.Nickname, AuthorId = track.User.Id, Rating = rate, PreviewUrl = $@"/assets/img/{track.Id}.jpg"};
                result.Add(item);
            }
            return result;
        }


        public static IEnumerable<TrackCardModel> GetPopularTracks()
        {
            using ApplicationContext db = new ApplicationContext();
            var tracks = db.Tracks
                .Include(t => t.User)
                .Select(t => new Tuple<Track, double>(t, t.GetTrackPopularity()))
                .ToList()
                .OrderByDescending(t => t.Item2)
                .ThenByDescending(t => t.Item1.GetTrackRate())
                .Select(t => t.Item1)
                .Take(6)
                .ToList();
            return CreateCardModels(tracks);
        }

        public static IEnumerable<TrackCardModel> GetNewTracks()
        {
            using ApplicationContext db = new ApplicationContext();
            var tracks = db.Tracks
                .Include(t => t.User)
                .OrderByDescending(track => track.Upload_Date)
                .Take(6)
                .ToList();
            return CreateCardModels(tracks);
        }

        public static IEnumerable<TrackCardModel> GetTrendingTracks()
        {
            using ApplicationContext db = new ApplicationContext();
            var tracks = db.Tracks
                .Include(t => t.User)
                .ToList()
                .OrderByDescending(t => t.GetNumberOfRatesLastWeek())
                .ThenByDescending(t => t.GetTrackRate())
                .Take(6)
                .ToList();
            return CreateCardModels(tracks);
        }
    }
}