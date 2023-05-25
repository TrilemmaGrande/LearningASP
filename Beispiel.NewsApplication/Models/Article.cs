using System;
using System.ComponentModel.DataAnnotations;

namespace Beispiel.NewsApplication.Models
{
    public class Article
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Titel muss angegeben werden")]
        public string Headline { get; set; }
        [Required(ErrorMessage = "Inhalt muss angegeben werden")]
        public string Content { get; set; }
        public DateTime Created { get; set; }
        [Required(ErrorMessage = "Autor muss angegeben werden")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Bitte den Daitenamen für das Bild angeben")]
        public string ImageFile { get; set; }
    }
}
