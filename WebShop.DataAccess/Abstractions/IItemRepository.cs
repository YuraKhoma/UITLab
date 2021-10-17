using System.Collections.Generic;
using WebShop.Common.Models;

namespace WebShop.DataAccess.Abstractions
{   /// <summary>
    /// Base interface that responds of items data accsess
    /// </summary>
    public interface IItemRepository : IRepository<Item>
    {
        List<Item> GetNewItems();
    }
}
