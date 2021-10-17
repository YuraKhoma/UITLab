using System;
using System.Collections.Generic;
using System.Linq;
using WebShop.Common.Models;
using WebShop.DataAccess.Abstractions;

namespace WebShop.DataAccess.Repositories
{
    /// <summary>
    /// Implementation of IItemRepository Interface
    /// </summary>
    public class ItemRepository : BaseRepository<Item>, IItemRepository
    {
        /// <summary>
        /// Returns list of items
        /// </summary>
        /// <returns></returns>
        public List<Item> GetNewItems()
        {
            return storage.Where(x => x.ItemStatus == ItemStatus.New)
                .ToList();
        }
    }
}
