using Microsoft.AspNetCore.Mvc;
using MyFirstProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProject.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult MyName()
        {
            return Content("<h1>Mileto<h2>","text/html");
        }


        public IActionResult SearchByIndex(int id)
        {
            return Content($"You searched product with id:{id}");
        }

        public IActionResult SearchByString(string needle)
        {
            return Content($"You searched product with string:{needle}");
        }

        [Route("/")]
        [Route("Home/")]
        [Route("Home/Index")]
        [Route("Landing")]
        public IActionResult Index()
        {
            return Content("Index","text/plain");
        }

        [Route("Home/About")]
        public IActionResult About()
        {
            ViewData["Message"] = "Dit is mijn eerste .NEt Core MVC app";

            return View();
        }

        [Route("Home/Contact")]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
