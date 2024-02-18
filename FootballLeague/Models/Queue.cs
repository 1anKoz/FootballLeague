using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballLeague.Models
{
    public class Queue
    {
        [Key]
        public int QueueId { get; set; }
        [ForeignKey("Match")]
        //public int? MatchId { get; set; }
        public List<Match>? Matches { get; set; }
        public int LeagueId { get; set; }
        public League League { get; set; }
    }
}