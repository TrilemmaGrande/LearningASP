using Beispiel.NewsApplicationDB.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Beispiel.NewsApplicationDB.Controllers
{
    public class HomeController : Controller
    {
        private IWebHostEnvironment hostingEnvironment;

        private NewsApplicationDBContext ctx;

        public HomeController(NewsApplicationDBContext ctx, IWebHostEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
            this.ctx = ctx;
        }
        public IActionResult Index()
        {
            List<Article> articles = ctx.Articles
                                        .OrderByDescending(a => a.Created)
                                        .ToList();
            IndexViewModel vm = new IndexViewModel()
            {
                TopArticle = articles.FirstOrDefault(),
                Articles = articles.Skip(1).ToList()
            };
            return View(vm);
        }
        [HttpGet]
        public IActionResult NewArticle()
        {
            GetImageFiles();
            return View();                     
        }
        [HttpPost]
        public IActionResult NewArticle(Article article)
        {
            if (ModelState.IsValid)
            {
                article.Created = DateTime.Now;
                int maxId = 0;
                if (ctx.Articles.Any())
                {
                    maxId = ctx.Articles.Max(a => a.Id);
                }
                article.Id = maxId + 1;
                ctx.Articles.Add(article);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                GetImageFiles();
                return View();
            }
        }
        public IActionResult Details(int id)
        {
            return View(ctx.Articles.FirstOrDefault(s => s.Id == id));
        }
        public IActionResult IndexDelete()
        {
            List<Article> articles = ctx.Articles
                                       .OrderByDescending(a => a.Created)
                                       .ToList();
            IndexViewModel vm = new IndexViewModel()
            {
                TopArticle = articles.FirstOrDefault(),
                Articles = articles.Skip(1).ToList()
            };
            return View(vm);
        }
        public IActionResult DeleteArticle(int id)
        {
            Article remove = ctx.Articles.FirstOrDefault(s => s.Id == id);

            ctx.Articles.Remove(remove);
            ctx.SaveChanges();

            return RedirectToAction("IndexDelete");
        }
        public IActionResult DeleteThisArticle(int id)
        {
            Article remove = ctx.Articles.FirstOrDefault(s => s.Id == id);

            ctx.Articles.Remove(remove);
            ctx.SaveChanges();

            return RedirectToAction("Index");
        }
        private void GetImageFiles()
        {
            string path = Path.Combine(hostingEnvironment.WebRootPath, "img");
            string[] imageFiles = Directory.GetFiles(path)
                                    .Select(s => Path.GetFileName(s))
                                    .ToArray();
            ViewData["ImageFiles"] = new SelectList(imageFiles);
        }
    }
}
