using Mission_6.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mission_6.Controllers
{
    public class MovieController : Controller
    {
        private readonly MovieCollectionContext _context;

        public MovieController(MovieCollectionContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(movie);
                _context.SaveChanges();
                return RedirectToAction("Confirmation");
            }
            return View(movie);
        }

        public IActionResult Confirmation()
        {
            return View();
        }
    }
}