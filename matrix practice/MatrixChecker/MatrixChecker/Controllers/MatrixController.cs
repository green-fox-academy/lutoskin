using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MatrixChecker.Services;
using MatrixChecker.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MatrixChecker.Controllers
{
    [Route("/")]
    public class MatrixController : Controller
    {
        private MatrixCheckerService matrixService;
     
        public MatrixController(MatrixCheckerService matrixService)
        {
            this.matrixService = matrixService;
        }

        [HttpGet]
        public IActionResult Index(IndexViewModel ivm)
        {
            return View(ivm);
        }

        [HttpPost("/matrix")]
        public IActionResult CheckMatrix(string matrixInput)
        {
            return RedirectToAction("Index", matrixService.CheckMatrix(matrixInput));
        }

        [HttpGet("/matrices")]
        public IActionResult GetMatrixes()
        {
            return Json(matrixService.GetMatrices());
        }
    }
}