using WebShop.Common.Models;

namespace WebShop.BL.Abstractions
{
    /// <summary>
    /// Responds of Order business logic 
    /// </summary>
    public interface IOrderManager
    {
        bool CreateOrder(Order order);
        bool CancelOrder(Order order);
    }
}
