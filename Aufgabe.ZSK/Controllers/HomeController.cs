using Aufgabe.ZSK.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Aufgabe.ZSK.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ZskToEur()
        {
            return View();
        }
        public IActionResult EurToZsk()
        {
            return View("Index");
        }
        public IActionResult Result(Calculator calc)
        {
            if (calc.EurToZsk)
            {
                calc.CalculateZSK();
            }
            else
            {
                calc.CalculateEUR();
            }
            return View(calc);
        }
    }
}
