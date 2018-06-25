using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using helloworld.Models;
using Microsoft.AspNetCore.Mvc;

namespace helloworld.Controllers
{
    public class WebController : Controller
    {
        static int counter;

        public IActionResult Greeting(string name)
        {
            counter++;

            var greeting = new Greeting()
            {
                Id = counter,
                Content = name
            };

            return View(greeting);
        }
    }
}