using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Frontend.Models;
using Frontend.Services;

namespace Frontend.Controllers
{
    public class HomeController : Controller
    {
        private HomeService homeService;

        public HomeController(HomeService homeService)
        {
            this.homeService = homeService;
        }

        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet("/doubling")]
        public IActionResult Doubling(int? input)
        {
            if (input == null)
            {
                return Json(new { error = "Please provide an input!" });
            }
            return Json(new { received = input, result = 2 * input });
        }

        [HttpGet("/greeter")]
        public IActionResult Greeter(string name, string title)
        {
            if (name == null )
            {
                return Json(new { error = "Please provide a name!" });
            }
            else if (title == null)
            {
                return Json(new { error = "Please provide a title!" });
            }
            return Json(new { welcome_message = $"Oh, hi there {name}, my dear {title}!" });
        }

        [HttpGet("/appenda/{appendable}")]
        public IActionResult Appenda(string appendable)
        {
            if (appendable == null)
            {
                return NotFound();
            }
            return Json(new { appended = $"{appendable}a" });
        }

        [HttpPost("/dountil/{what}")]
        public IActionResult DoUntil([FromBody]Number number, string what)
        {
            if (number.Until == 0)
            {
                return Json(new { error = "Please provide a number!" });
            }
            else if (what == "sum")
            {
                return Json(new { result = homeService.Sum(number) });
            }
            else if (what == "factor")
            {
                return Json(new { result = homeService.Factorial(number) });
            }
            
            return Json(new { error = "Please provide a number!" });
        }

        [HttpPost("/arrays")]
        public IActionResult Arrays([FromBody] ArrayModel array)
        {
            if (array.What == "sum")
            {
                return Json(new { result = homeService.ArraySum(array) });
            }
            else if (array.What == "multiply")
            {
                return Json(new { result = homeService.ArrayMultiply(array) });
            }
            else if (array.What == "double")
            {
                return Json(new { result = homeService.ArrayDouble(array) });
            }
            return null;
        }
    }
}
