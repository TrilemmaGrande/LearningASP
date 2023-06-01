using Beispiel.Sportsstore.Models;
using Beispiel.Sportsstore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Beispiel.Sportsstore.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repo;
        private int PageSize = 4;
        public HomeController(IStoreRepository repo)
        {
            this.repo = repo;
        }
        public IActionResult Index(string category, int productPage = 1)
        {
            ProductListViewModel plvm = new ProductListViewModel()
            {
                Products = repo.Products
                            .Where(p => category == null || p.Category == category)
                            .OrderBy(p => p.ProductID)
                            .Skip((productPage - 1) * PageSize)
                            .Take(PageSize),
                PagingInfo = new PagingInfo()
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = repo.Products
                                    .Where(p => category == null || p.Category == category)
                                    .Count()
                },
                CurrentCategory = category
            };
            return View(plvm);
        }
        [HttpGet]
        public IActionResult Cart(string returnUrl)
        {
            returnUrl = returnUrl ?? "/";
            return View();
        }
        [HttpPost]
        public IActionResult Cart(long productId, string returnUrl)
        {
            return RedirectToAction(nameof(Cart), new {returnUrl});
        }
    }
}
