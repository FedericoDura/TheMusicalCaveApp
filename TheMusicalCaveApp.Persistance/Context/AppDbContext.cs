using System.Data.Entity;
using TheMusicalCaveApp.Models.Entities;

namespace TheMusicalCaveApp.Persistance.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
            : base("TheMusicalCaveDB")
        {
        }

        public DbSet<AlbumEntity> Albums { get; set; }
        public DbSet<TrackEntity> Tracks { get; set; }
    }
}
