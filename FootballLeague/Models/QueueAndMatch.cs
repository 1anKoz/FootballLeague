using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballLeague.Models
{
    public class QueueAndMatch
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Match")]
        public List<Match>? Matches { get; set; }
        [ForeignKey("Queue")]
        public List<Queue>? Queues { get; set; }
    }
}
