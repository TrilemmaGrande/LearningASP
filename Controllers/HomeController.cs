using Beispiel.FirstWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace LearningASP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string uhrzeit = DateTime.Now.ToShortTimeString();
            string text = DateTime.Now.Hour < 12 ? "Guten Morgen" : "Guten Tag";

            DifferentViewViewModel vm = new DifferentViewViewModel()
            {
                Uhrzeit = uhrzeit,
                Text = text
            };
            return View("DifferentView", vm);
        }
    }
}
