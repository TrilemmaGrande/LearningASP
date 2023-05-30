using Beispiel.Sportsstore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Beispiel.Sportsstore.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repo;
        public HomeController(IStoreRepository repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            return View(repo.Products);
        }
    }
}
