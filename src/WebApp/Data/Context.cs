using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<VideoGame> VideoGames { get; set; }
        public DbSet<Platform> Platforms { get; set; }
    }
}
