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
        public IActionResult Index(int productPage = 1)
        {
            ProductListViewModel plvm = new ProductListViewModel()
            {
                Products = repo.Products
                            .OrderBy(p => p.ProductID)
                            .Skip((productPage - 1) * PageSize)
                            .Take(PageSize),
                PagingInfo = new PagingInfo()
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = repo.Products.Count()
                }
            };
            return View(plvm);
        }
    }
}
