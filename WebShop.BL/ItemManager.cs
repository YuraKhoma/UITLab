using System;
using System.Collections.Generic;
using System.Linq;
using WebShop.BL.Abstractions;
using WebShop.Common.Models;
using WebShop.DataAccess.Abstractions;

namespace WebShop.BL
{
    /// <summary>
    /// Implements IItemManager interface
    /// </summary>
    public class ItemManager : IItemManager
    {
        private readonly IItemRepository itemRepository;

        public ItemManager(IItemRepository itemRepository)
        {
            this.itemRepository = itemRepository;
        }

        /// <summary>
        /// Ads new item
        /// </summary>
        /// <param name="item"></param>
        public void AddItem(Item item)
        {
            item.ItemStatus = ItemStatus.New;
            this.itemRepository.Create(item);
        }

        /// <summary>
        /// Finds item by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Item FindByName(string name)
        {
            Item item = GetItemsList().FirstOrDefault(x => x.Title == name);
            while(true)
            {
                if (item != null)
                {
                    return item;
                }
                else
                {
                    throw new NullReferenceException(nameof(item));
                }
            }
            
        }

        /// <summary>
        /// Returns list of items
        /// </summary>
        /// <returns></returns>
        public List<Item> GetItemsList()
        {
            var allItems = itemRepository.GetNewItems();
            return allItems;
        }

        /// <summary>
        /// Updates item
        /// </summary>
        /// <param name="item"></param>
        public void UpdateItem(Item item)
        {
            throw new NotImplementedException();
        }

    }
}
