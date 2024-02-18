using FootballLeague.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<League>()
                .HasMany(l => l.Queues)
                .WithOne(q => q.League)
                .HasForeignKey(q => q.LeagueId)
                .IsRequired();

            modelBuilder.Entity<Queue>()
                .HasMany(q => q.Matches)
                .WithOne(m => m.Queue)
                .HasForeignKey(m => m.QueueId)
                .IsRequired();

            modelBuilder.Entity<Match>()
                .Property(m => m.MatchId)
                .ValueGeneratedOnAdd();
        }
    }
}
