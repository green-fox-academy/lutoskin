using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using helloworld.Models;
using Microsoft.AspNetCore.Mvc;

namespace helloworld.Controllers
{
    [Route("api")]
    public class RESTController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        static int counter;

        [Route("greeting")]
        public IActionResult Greeting(string name)
        {           
            counter++;

            Greeting greeting = new Greeting()
            {
                Id = counter,
                Content = "Hello " + name               
            };
            return Ok(greeting);
                             
        }
    }
}