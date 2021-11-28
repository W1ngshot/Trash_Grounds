using Microsoft.EntityFrameworkCore;
using TrashGrounds.Models.Database;

namespace TrashGrounds.Services.Database;

public class ApplicationContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Track> Tracks { get; set; }
    public DbSet<Rate> Rates { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<CommunityMsg> CommunityMsgs { get; set; }
    
    public ApplicationContext()
    {
        Database.EnsureCreated();
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=myNewDataBase;Trusted_Connection=True;");
    }
}
