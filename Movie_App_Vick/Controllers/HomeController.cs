using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movie_App_Vick.Models;
using System.Diagnostics;

namespace Movie_App_Vick.Controllers
{
    public class HomeController : Controller
    {
        private MovieApplicationContext _context;

        public HomeController(MovieApplicationContext data) //Constructor
        {
            _context = data;
        }

        public IActionResult Index() //Index action
        {
            return View();
        }

        public IActionResult Info() //joel info action
        { 
            return View(); 
        }

        [HttpGet]
        public IActionResult MovieEntry() //form action
        {
            ViewBag.Categories = _context.Categories.ToList();

            return View(new Application());
        }

        [HttpPost]
        public IActionResult MovieEntry(Application response) //post form action
        {
            _context.Movies.Add(response);
            _context.SaveChanges();

            return View("ThankYou", response);
        }

        public IActionResult MovieList()
        {
            var applications = _context.Movies
                .Include(x => x.Category)
                .ToList();

            return View(applications);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var editRecord = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories.ToList();

            return View("MovieEntry", editRecord);
        }

        [HttpPost]
        public IActionResult Edit(Application updates)
        {
            _context.Update(updates);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var deleteRecord = _context.Movies
                .Single(x => x.MovieId == id);

            return View(deleteRecord);
        }

        [HttpPost]
        public IActionResult Delete(Application deleted)
        {
            _context.Movies.Remove(deleted);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
