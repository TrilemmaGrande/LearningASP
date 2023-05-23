using Microsoft.AspNetCore.Mvc;

namespace Beispiel.NewsApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
