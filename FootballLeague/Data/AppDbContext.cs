using FootballLeague.Models;
using Microsoft.EntityFrameworkCore;

namespace FootballLeague.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Match> Matches { get; set; }
        public DbSet<Queue> Queues { get; set; }
        public DbSet<League> Leagues { get; set; }
    }
}
