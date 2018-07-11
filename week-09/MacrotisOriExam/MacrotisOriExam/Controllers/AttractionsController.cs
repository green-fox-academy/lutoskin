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
            return RedirectToAction("Index");
        }

        [HttpGet("/edit/{id}")]
        public IActionResult EditAttraction(int id)
        {
            var attractionEditViewModel = new EditViewModel() { Attractions = attractionsService.GetAttractions(), Attraction = attractionsService.GetAttractionById(id) };
            return View("Edit", attractionEditViewModel);
        }

        [HttpPost("/edit")]
        public IActionResult EditAttraction(Attractions attraction)
        {
            attractionsService.EditAttraction(attraction);
            return RedirectToAction("Index");
        }

        [HttpGet("/filter")]
        public IActionResult FilterAttractions(string category, string city)
        {
            List<Attractions> filteredAttractions = attractionsService.GetAttractionsByCategoryAndCity(category, city);
            var filterDTO = new FilterDTO() { Result = "ok", Count = filteredAttractions.Count(), Attractions = filteredAttractions };
            return Json(filterDTO);
        }
    }
}