using FootballLeague.Models;

namespace FootballLeague.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                if (!context.Leagues.Any())
                {
                    context.Leagues.AddRange(
                    new List<League>()
                    {
                        new League()
                        {
                            LeagueName = "Jupiler Pro League",
                            LegueSeason = "2022/2023",
                            Queues = new List<Queue>()
                            {
                                new Queue() {
                                    Matches = new List<Match>()
                                    {
                                        new Match()
                                        {
                                            Date = "00.00.0000",
                                            Time = "00:00",
                                            Team1 = "team1",
                                            Team2 = "team2",
                                            Score = "2:1"
                                        },
                                        new Match()
                                        {
                                            Date = "00.00.0000",
                                            Time = "00:00",
                                            Team1 = "team1",
                                            Team2 = "team2",
                                            Score = "2:1"
                                        }
                                    }
                                }
                            }
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
