using Aufgabe.Einkaufsliste.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Aufgabe.Einkaufsliste.Controllers
{
    public class HomeController : Controller
    {        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListAdder()
        {
            return View();
        }
        public IActionResult Confirmation(Item item)
        {
            Repository.AddItem(item);
            return View(item);
        }
        public IActionResult ListViewer()
        {
            return View(Repository.GetItems());
        }
        public IActionResult SubItem(int item)
        {
            Repository.items.RemoveAt(item);
            return View("ListViewer", Repository.GetItems());
        }
    }
}
