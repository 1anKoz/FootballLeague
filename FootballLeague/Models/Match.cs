using System.ComponentModel.DataAnnotations;

namespace FootballLeague.Models
{
    public class Match
    {
        [Key]
        public int MatchId { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public string Score { get; set; }
        public int QueueId { get; set; }
        public virtual Queue Queue{ get; set; }
    }
}
