using System.ComponentModel.DataAnnotations;

namespace FootballLeague.Models
{
    public class League
    {
        [Key]
        public int LeagueId { get; set; }
        public string LeagueName { get; set; }
        public string LegueSeason { get; set; }
        public List<Queue> Queues { get; set; }
    }
}
