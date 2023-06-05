using Beispiel.Sportsstore.Infrastructure;
using Beispiel.Sportsstore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Beispiel.Sportsstore.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository repo;
        public OrderController(IOrderRepository repo)
        {
            this.repo = repo;
        }
        [HttpGet]
        public IActionResult Checkout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            Cart cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            if (cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your cart is empty!");
            }
            if (ModelState.IsValid)
            {
                order.Lines = cart.Lines.ToArray();
                repo.SaveOrder(order);
                cart.Clear();
                HttpContext.Session.SetJson("cart", cart);
                return View("Completed", order.OrderId);
            }
            else
            {
                return View();
            }
        }
    }
}
