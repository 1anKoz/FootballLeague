using FootballLeague.Data;
using FootballLeague.Models;
using Microsoft.AspNetCore.Mvc;

namespace FootballLeague.Controllers
{
    public class LeagueController : Controller
    {
        private readonly AppDbContext _context;
        public LeagueController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<League> leagues = _context.Leagues.ToList();
            return View(leagues);
        }
    }
}
