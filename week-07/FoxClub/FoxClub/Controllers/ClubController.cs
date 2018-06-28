using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxClub.Services;
using Microsoft.AspNetCore.Mvc;

namespace FoxClub.Controllers
{
    public class ClubController : Controller
    {
        IClub foxClubExample;

        public ClubController(IClub club)
        {
            foxClubExample = club;
        }

        [HttpPost]
        public IActionResult Index(string name)
        {
            object nameObj = name.Clone();
            return View(nameObj);
        }

    }
}