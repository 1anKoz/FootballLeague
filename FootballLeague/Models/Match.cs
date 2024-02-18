using System.ComponentModel.DataAnnotations;

namespace FootballLeague.Models
{
    public class Match
    {
        [Key]
        public int MatchId { get; set; }
        public string Date { get; set; } = string.Empty;
        public string Time { get; set; } = string.Empty;
        public string Team1 { get; set; } = string.Empty;
        public string Team2 { get; set; } = string.Empty;
        public string Score { get; set; } = string.Empty;
        public int QueueId { get; set; }
        public Queue Queue { get; set; }
    }
}
