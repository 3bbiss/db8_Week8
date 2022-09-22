using Microsoft.AspNetCore.Mvc;
using ModelDemo1.Models;
using System;
using System.Diagnostics;

namespace ModelDemo1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Sample()
        {
            Person fred = new Person() { FirstName = "Fred", LastName = "Franklin", Email = "Fred@abc.com", Born = 1970 };
            return View(fred);
        }

        public IActionResult SampleList()
        {
            List<Person> people = new List<Person>();

            Person per = new Person() { FirstName = "Fred", LastName = "Franklin", Email = "Fred@abc.com", Born = 1970 };
            people.Add(per);

            per = new Person() { FirstName = "Sally", LastName = "Smith", Email = "ssmith@rm.com", Born = 1996 };
            people.Add(per);

            per = new Person() { FirstName = "Julia", LastName = "Jones", Email = "jjones@rm.com", Born = 2000 };
            people.Add(per);

            ViewData["Department"] = "IT";
            ViewData["Year"] = 2022;

            return View(people);
        }

        public IActionResult ShowRegister()
        {
            return View();
        }

        public IActionResult Register(Person per)
        {
            if (per.Born > 2004)
            {
                // Let's use a different view born < 2004
                // We'll call the view Under18.cshtml
                //return View("Under18");
                //return Redirect("/home/index");
                ViewBag.BornMessage = "*Please make sure you were born 2004 or earlier";
                return View("ShowRegister");
            }
            else
            {
                return View(per);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}