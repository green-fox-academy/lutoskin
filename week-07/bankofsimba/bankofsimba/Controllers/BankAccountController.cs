using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bankofsimba.Models;
using Microsoft.AspNetCore.Mvc;

namespace bankofsimba.Controllers
{
    public class BankAccountController : Controller
    {      


        public IActionResult Index()
        {
            return View();
        }

        [Route("simba")]
        public IActionResult Simba()
        {
            BankAccount bankAccount = new BankAccount()
            {
                Name = "Simba",
                Balance = 2000.ToString("0.00") + " Zebra",
                AnimalType = "Animal.Lion"
            };

            return View(bankAccount);
        }

        [Route("account")]
        public IActionResult Account()
        {
            return View(bankAccounts);
        }
    }
}