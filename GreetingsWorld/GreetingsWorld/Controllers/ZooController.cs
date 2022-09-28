using GreetingsWorld.Data;
using GreetingsWorld.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreetingsWorld.Controllers
{
    public class ZooController : Controller
    {

        private readonly ApplicationDbContext _db;

        public ZooController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Result(int animalId)
        {
            IEnumerable<Animal> animalQuery =
                (from Animals in _db.Animals
                 where Animals.animalId == animalId
                 select Animals).ToList();

            return View("Result", animalQuery);
        }

        public IActionResult RandomResult()
        {
            Random rand = new Random();
            int num = rand.Next(1, 10);

            List<Animal> animalList = new List<Animal>();
            Animal animalInstance = new Animal();
            animalInstance = _db.Animals.Find(num);

            animalList.Add(animalInstance);

            return View("Result", animalList);
        }
    }
}
