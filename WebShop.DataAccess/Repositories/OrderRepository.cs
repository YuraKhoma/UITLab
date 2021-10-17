using System.Collections.Generic;
using System.Linq;
using WebShop.Common.Models;
using WebShop.DataAccess.Abstractions;

namespace WebShop.DataAccess.Repositories
{
    /// <summary>
    /// Implementation of IOrderRepository
    /// </summary>
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public List<Order> GetNewOrders()
        {
            throw new System.NotSupportedException();
        }
    }
}
