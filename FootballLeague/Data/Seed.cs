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
                                            Date = "23-07-2022",
                                            Time = "16:00",
                                            Team1 = "Charleroi",
                                            Team2 = "Eupen",
                                            Score = "3:1"
                                        },
                                        new Match()
                                        {
                                            Date = "23-07-2022",
                                            Time = "18:15",
                                            Team1 = "Kortrijk",
                                            Team2 = "OH Leuven",
                                            Score = "0:2"
                                        }
                                    }
                                },
                                new Queue() {
                                    Matches = new List<Match>()
                                    {
                                        new Match()
                                        {
                                            Date = "23-07-2022",
                                            Time = "18:15",
                                            Team1 = "Zulte",
                                            Team2 = "RfC Seresien",
                                            Score = "2:0"
                                        },
                                        new Match()
                                        {
                                            Date = "23-07-2022",
                                            Time = "20:45",
                                            Team1 = "Saint-Truiden",
                                            Team2 = "Union Saint-Gilloise",
                                            Score = "1:1"
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
