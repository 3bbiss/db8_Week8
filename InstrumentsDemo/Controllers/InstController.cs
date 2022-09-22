using InstrumentsDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace InstrumentsDemo.Controllers
{
    public class InstController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowForm()
        {

            return View();
        }

        public IActionResult Add(Instrument inst)
        {
            bool errorFound = false;
            // Validate
            if (inst.Year > DateTime.Now.Year)
            {
                ViewBag.YearMessage = "Enter valid year!";
                errorFound = true;
            }
            if (inst.Price <= 0)
            {
                ViewBag.PriceMessage = "Price not >0!";
                errorFound = true;
            }
            if (errorFound)
            {
                return View("ShowForm");
            }
            else
            {
                return View(inst);
            }

        }
    }
}
