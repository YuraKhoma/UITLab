using WebShop.BL.Abstractions;
using WebShop.Common.Models;
using WebShop.DataAccess.Abstractions;

namespace WebShop.BL
{
    /// <summary>
    /// Implements IOrerManager
    /// </summary>
    public class OrderManager : IOrderManager
    {
        private readonly IItemRepository itemRepository;
        private readonly IOrderRepository orderRepository;
        private readonly IAuthorizationManager authorizationManager;
        private readonly IUserManager userManager;

        public OrderManager(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public OrderManager(IItemRepository itemRepository, IOrderRepository orderRepository)
        {
            this.itemRepository = itemRepository;
            this.orderRepository = orderRepository;
        }

        /// <summary>
        /// Generate new order
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public bool CreateOrder(Order order)
        {
            //if(authorizationManager.RegisterUser() != null)

            orderRepository.Create(order);
            return true;
        }

        /// <summary>
        /// Cancels order
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public bool CancelOrder(Order order)
        {
            orderRepository.GetById(order.Id);
            order.OrderStatus = OrderStatus.Canceled;
            return true;
        }
    }
}
