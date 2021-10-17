using WebShop.Common.Models;

namespace WebShop.DataAccess.Abstractions
{
    /// <summary>
    /// Base interface that responds of order data accsess
    /// </summary>
    public interface IOrderRepository : IRepository<Order>
    {
    }
}
