using System.Collections.Generic;

namespace Aufgabe.Einkaufsliste.Models
{
    public static class Repository
    {
        private static List<Item> items = new List<Item>();

        public static void AddItem(Item item)
        {
            items.Add(item);
        }
        public static List<Item> GetItems()
        {
            return items;
        }
        public static void RemoveItem(int itemID)
        {
            items.Remove(CompareItems(itemID));
        }
        public static void AddAmount(int itemID)
        {
            CompareItems(itemID).Amount += 1;
        }
        public static void SubAmount(int itemID)
        {
            CompareItems(itemID).Amount -= 1;
        }
        private static Item CompareItems(int itemID)
        {
            foreach (var item in items)
            {
                if (item.ID == itemID)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
