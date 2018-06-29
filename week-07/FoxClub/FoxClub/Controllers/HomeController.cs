using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoxClub.Models;
using FoxClub.Services;

namespace FoxClub.Controllers
{
    public class HomeController : Controller
    {
        IClub club;

        public HomeController(IClub club)
        {
            this.club = club;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult HolyFood()
        {
            return View((object)club.GetLatestFox().Name);
        }

        public IActionResult TricksterMachine()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("login")]
        public IActionResult Login()
        {
            return View();
        }
    }
}
