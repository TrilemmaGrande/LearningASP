using System.Collections.Generic;

namespace Aufgabe.Einkaufsliste.Models
{
    public static class Repository
    {
        public static List<Item> items = new List<Item>();

        public static void AddItem(Item item)
        {
            items.Add(item);
        }
        public static List<Item> GetItems()
        {
            return items;
        }
    }
}
