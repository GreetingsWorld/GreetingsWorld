using GreetingsWorld.Data;
using GreetingsWorld.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GreetingsWorld.Controllers
{
    public class CommentController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CommentController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Index(int worldId)
        {
            IEnumerable<Comment> commentQuery =
                (from Comments in _db.Comments
                where Comments.worldId == worldId
                select Comments).ToList();

            if (commentQuery.Count() == 0)
            {
                return RedirectToRoute(new { controller = "Comment", action = "None", id = worldId});
            }
            return View("Index", commentQuery);
        }

        [HttpGet]
        public IActionResult None()
        {
            return View();
        }


        public IActionResult addComment()
        {
            return View();
        }
    }
}
