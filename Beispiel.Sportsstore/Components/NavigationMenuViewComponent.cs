using Beispiel.Sportsstore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Beispiel.Sportsstore.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IStoreRepository repo;
        public NavigationMenuViewComponent(IStoreRepository repo)
        {
            this.repo = repo;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repo.Products
                                .Select(p => p.Category)
                                .Distinct()
                                .OrderBy(c => c));
        }
    }
}
