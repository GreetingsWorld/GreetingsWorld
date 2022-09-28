using GreetingsWorld.Data;
using GreetingsWorld.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreetingsWorld.Controllers
{
    public class WorldController : Controller
    {
        private readonly ApplicationDbContext _db;

        public WorldController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<World> objClassList = _db.Worlds.ToList();
            return View(objClassList);
        }
    }
}
