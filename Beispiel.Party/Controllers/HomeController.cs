using Beispiel.Party.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Beispiel.Party.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(guestResponse);
                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }

        }
        public IActionResult ListResponses()
        {
            return View(Repository.GetResponses()
                                    .Where(r => r.WillAttend == true).ToList());
        }
    }
}
