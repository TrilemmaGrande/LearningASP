using System.ComponentModel.DataAnnotations;

namespace Aufgabe.Einkaufsliste.Models
{
    public class Item
    {
        public static int UniqueID { get; private set; } = 0;
        public int ID { get; private set; }
        [Required(ErrorMessage = "item name is required!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "item amount is required!")]
        [Range(1,50)]
        public int Amount { get; set; }
        [Required(ErrorMessage = "shop name is required!")]
        public string Store { get; set; }

        public Item()
        {
            UniqueID++;
            ID = UniqueID;
        }
    }
}
