using Microsoft.AspNetCore.Mvc;
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
            return View();
        }

        [HttpPost]
        public IActionResult MovieEntry(Application response) //post form action
        {
            _context.Applications.Add(response);
            _context.SaveChanges();

            return View("ThankYou", response);
        }
    }
}
