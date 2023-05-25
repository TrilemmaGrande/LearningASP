using Microsoft.AspNetCore.Mvc;

namespace NewApplicationDB.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
