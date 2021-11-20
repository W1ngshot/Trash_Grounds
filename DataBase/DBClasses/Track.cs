using System;

namespace TrashGrounds.DataBase.DBClasses
{
    public class Track
    {
        public int Id { get; set; }
        
        public string Title { get; set; }
        
        public string Description { get; set; }
        
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        
        public bool IsExplicit { get; set; }
        
        public int UserId { get; set; }
        public User User { get; set; }
        
        public DateTime Upload_Date { get; set; }
        
        public int Asset_Id { get; set; }
    }
}