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

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ChooseAgain()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Result(int animalId)
        {
            List<Animal> animalCount = _db.Animals.ToList();

            if (animalId <= 0 || animalId > animalCount.Count)
            {
                return RedirectToRoute(new { controller = "Zoo", action = "ChooseAgain" });
            }

            List<Animal> animalList = new List<Animal>();

            Animal animalInstance = _db.Animals.Find(animalId);

            animalList.Add(animalInstance);

            return View("Result", animalList);
        }

        [HttpGet]
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

        public IActionResult AddAnimal()
        {
            return View();
        }
    }
}
