using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WonderHorseStable.Models;
using WonderHorseStable.Repositories;
using WonderHorseStable.Services;

namespace WonderHorseStable.Controllers
{
    public class StableController : Controller
    {
        private StableService stableService;

        public StableController(StableService stableService)
        {
            this.stableService = stableService;
        }

        public IActionResult Index()
        {
            return View(stableService.GetHorses());
        }

        [HttpPost]
        public IActionResult AddHorse(Horse horse)
        {
            stableService.AddHorse(horse);
            return Redirect("Edit");
        }

        [HttpPost]
        public IActionResult ChangeToTrained(long id)
        {
            stableService.ChangeToTrained(id);           
            return Redirect("Edit");
        }

        [HttpPost]
        public IActionResult ChangePermission(long id)
        {
            stableService.ChangePermission(id);
            return Redirect("Edit");
        }

        [HttpPost]
        public IActionResult DeleteRecord(long id)
        {
            stableService.DeleteRecord(id);
            return Redirect("Edit");
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return View(stableService.GetHorses());
        }

        [HttpPost]
        public IActionResult Search(string searchString)
        {          
            return View("Index", stableService.SearchByName(searchString));
        }
    }
}
