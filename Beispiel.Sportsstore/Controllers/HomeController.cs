﻿using Beispiel.Sportsstore.Infrastructure;
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
            CartViewModel cvm = new CartViewModel()
            {
                Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart(),
                ReturnUrl = returnUrl ?? "/"
            };
            return View(cvm);
        }
        [HttpPost]
        public IActionResult Cart(long productId, string returnUrl)
        {
            Cart cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            Product product = repo.Products
                                .FirstOrDefault(p => p.ProductID == productId);
            cart.AddItem(product, 1);
            HttpContext.Session.SetJson("cart", cart);
            return RedirectToAction(nameof(Cart), new {returnUrl});
        }
        public IActionResult RemoveLine(long productId, string returnUrl)
        {
            Cart cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            Product product = cart.Lines.First(l => l.Product.ProductID == productId).Product;
            cart.RemoveLine(product);
            HttpContext.Session.SetJson("cart", cart);
            return RedirectToAction(nameof(Cart), new { returnUrl });
        }
        public IActionResult IncreaseLine(long productId, string returnUrl)
        {
            Cart cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            CartLine line = cart.Lines.First(l => l.Product.ProductID == productId);
            line.Quantity++;
            HttpContext.Session.SetJson("cart", cart);
            return RedirectToAction(nameof(Cart), new { returnUrl });
        }
        public IActionResult DecreaseLine(long productId, string returnUrl)
        {
            Cart cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            CartLine line = cart.Lines.First(l => l.Product.ProductID == productId);            
            line.Quantity -= line.Quantity > 0 ? 1 : 0;             
            HttpContext.Session.SetJson("cart", cart);
            return RedirectToAction(nameof(Cart), new { returnUrl });
        }
    }
}
