using Game_Catalog.Data;
using Game_Catalog.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Game_Catalog.Controllers
{
    public class HomeController(AppDBContext context) : Controller
    {
        private readonly AppDBContext _context = context;

        public IActionResult Index()
        {
            List<Games> games = _context.Games.ToList();
            return View(games);
        }

        public IActionResult AddGame()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddGame(Games game)
        {
            if (!ModelState.IsValid)
            {
                return View(game);
            }
            _context.Games.Add(game);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
