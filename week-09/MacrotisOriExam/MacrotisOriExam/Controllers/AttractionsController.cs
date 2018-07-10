using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MacrotisOriExam.Models;
using MacrotisOriExam.Services;
using MacrotisOriExam.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MacrotisOriExam.Controllers
{
    [Route("attractions")]
    public class AttractionsController : Controller
    {
        private AttractionsService attractionsService;

        public AttractionsController(AttractionsService attractionsService)
        {
            this.attractionsService = attractionsService;
        }

        public IActionResult Index()
        {
            return View(attractionsService.GetAttractions());
        }

        [HttpPost("/add")]
        public IActionResult AddAttraction(Attractions attraction)
        {
            attractionsService.AddAttraction(attraction);
            return Redirect("Index");
        }

        [HttpGet("/edit/{id}")]
        public IActionResult EditAttraction(int id)
        {
            var attractionEditViewModel = new EditViewModel() { Attractions = attractionsService.GetAttractions(), Attraction = attractionsService.GetAttractionById(id) };
            return View("Edit", attractionEditViewModel);
        }

        [HttpGet("/filter")]
        public IActionResult FilterAttractions([FromQuery]string category, [FromQuery]string city)
        {
            return View("Index", attractionsService.GetAttractionsByNameAndCategory(category, city));
        }
    }
}