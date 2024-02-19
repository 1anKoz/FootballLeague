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
            List<Match> matches= _context.Matches.ToList();
            return View(matches);
        }
    }
}
