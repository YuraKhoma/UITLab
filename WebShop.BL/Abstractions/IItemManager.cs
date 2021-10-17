using System.Collections.Generic;
using WebShop.Common.Models;

namespace WebShop.BL.Abstractions
{
    /// <summary>
    /// Interface that responds of item mamagement business logic
    /// </summary>
    public interface IItemManager
    {
        List<Item> GetItemsList();

        Item FindByName(string name);

        void AddItem(Item item);

        void UpdateItem(Item item);
    }
}
