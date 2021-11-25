using System;

namespace TrashGrounds.Models.Database;

public class Rate
{
    public int Id { get; set; }
    
    public int UserId { get; set; }
    public User User { get; set; }
    
    public int? TrackId { get; set; }
    public Track Track { get; set; }
    
    public int Rating { get; set; }
    
    public DateTime Date { get; set; }
}
