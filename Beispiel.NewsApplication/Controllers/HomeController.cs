using Beispiel.NewsApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Beispiel.NewsApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Article> articles = ArticleRepository.GetAllArticles()
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
            return View();                     
        }
        [HttpPost]
        public IActionResult NewArticle(Article article)
        {
            if (ModelState.IsValid)
            {
                article.Created = DateTime.Now;
                int maxId = 0;
                if (ArticleRepository.GetAllArticles().Any())
                {
                    maxId = ArticleRepository.GetAllArticles().Max(a => a.Id);
                }
                article.Id = maxId + 1;
                ArticleRepository.AddArticle(article);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        public IActionResult Details(int id)
        {
            return View(ArticleRepository.GetArticleById(id));
        }
        public IActionResult IndexDelete()
        {
            List<Article> articles = ArticleRepository.GetAllArticles()
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
            ArticleRepository.DeleteArticle(id);

            return RedirectToAction("IndexDelete");
        }
    }
}
