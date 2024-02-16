using System.ComponentModel.DataAnnotations;

namespace FootballLeague.Models
{
    public class Queue
    {
        [Key]
        public int QueueId { get; set; }
        public List<Match> Matches { get; set; }
    }
}