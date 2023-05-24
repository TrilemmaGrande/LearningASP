using System.Collections.Generic;

namespace Beispiel.NewsApplication.Models
{
    public class IndexViewModel
    {
        public Article TopArticle { get; set; }
        public List<Article> Articles { get; set; }
    }
}
