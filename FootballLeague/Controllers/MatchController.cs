using FootballLeague.Data;
using FootballLeague.Models;
using Microsoft.AspNetCore.Mvc;

namespace FootballLeague.Controllers
{
    public class MatchController : Controller
    {
        private readonly AppDbContext _context;
        public MatchController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = new QueueAndMatch();
            model.qmMatches =
                (List<Match>)_context.Matches
                .Take(10)
                .Select(m => new Match
                {
                    MatchId = m.MatchId,
                    Date = m.Date,
                    Time = m.Time,
                    Team1 = m.Team1,
                    Team2 = m.Team2,
                    Score = m.Score
                });
            model.qmQueues =
                (List<Queue>)_context.Queues
                .Take(10)
                .Select(q => new Queue
                {
                    QueueId = q.QueueId

                });

            return View(model);
            //List<Match> matches= _context.Matches.ToList();
            //return View(matches);
        }
    }
}
