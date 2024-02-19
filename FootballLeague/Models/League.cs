using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballLeague.Models
{
    public class League
    {
        [Key]
        public int LeagueId { get; set; }
        public string LeagueName { get; set; } = string.Empty;
        public string LegueSeason { get; set; } = string.Empty;
        [ForeignKey("Queue")]
        public List<Queue>? Queues { get; set; }
    }
}
