using System;
using WebShop.BL.Abstractions;
using WebShop.Common.Models;

namespace WebShop
{
    /// <summary>
    /// Implementation of IItemManagerUI
    /// </summary>
    public class ItemManagerUI : IItemManagerUI
    {
        private readonly IItemManager itemManager;

        public ItemManagerUI(IItemManager itemManager)
        {
            this.itemManager = itemManager;
        }

        /// <summary>
        /// Prints on console all items
        /// </summary>
        public void PrintAllItems()
        {
            var allItems = itemManager.GetItemsList();

            if (allItems.Count == 0)
            {
                Console.WriteLine("Nothing found");
                return;
            }

            foreach (var item1 in allItems)
            {
                Console.WriteLine($"{item1.Id}, {item1.ItemStatus}, {item1.Price}, {item1.Title}");
            }
        }

        /// <summary>
        /// Prins on console name of item by id
        /// </summary>
        public void FindByNameUI()
        {
            Console.WriteLine("Pleace, enter name:");
            string name = Console.ReadLine();
            var item1 = itemManager.FindByName(name);

            if (item1 != null)
            {
                Console.WriteLine($"{item1.Id}, {item1.ItemStatus}, {item1.Price}, {item1.Title}, {item1.Description}");
            }
            else
            {
                Console.WriteLine("Nothing found");
            }
        }
    }

}
