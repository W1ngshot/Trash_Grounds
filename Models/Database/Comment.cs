using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrashGrounds.Models.Database;

public class Comment
{
    public int Id { get; set; }
    
    public string Message { get; set; }
    
    public DateTime Date { get; set; }
    
    public int UserId { get; set; }
    public User User { get; set; }
    
    public int? TrackId { get; set; }
    public Track Track { get; set; }
}