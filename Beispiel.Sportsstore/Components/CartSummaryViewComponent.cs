using Beispiel.Sportsstore.Models;
using Beispiel.Sportsstore.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Beispiel.Sportsstore.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Cart cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            return View(cart);
        }
    }
}
