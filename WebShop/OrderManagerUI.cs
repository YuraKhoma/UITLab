using System;
using System.Linq;
using WebShop.BL.Abstractions;
using WebShop.Common.Models;
using WebShop.DataAccess.Abstractions;

namespace WebShop
{
    /// <summary>
    /// Implementation of 
    /// </summary>
    public class OrderManagerUI : IOrderManagerUI
    {
        private readonly IOrderManager orderManager;
        private readonly IUserManager userManager;
        private readonly IItemManager itemManager;
        private readonly IAuthorizationManager authorizationManager;
        private readonly IOrderRepository orderRepository;

        public OrderManagerUI(IOrderManager orderManager)
        {
            this.orderManager = orderManager;
        }

        /// <summary>
        /// User interface of creating order
        /// </summary>
        /// <returns></returns>
        public Order CreateNewOrder()
        {
            Console.WriteLine("Pleace enter your login");
            string login = Console.ReadLine();
            Console.WriteLine("Pleace enter name of item:");
            string title = Console.ReadLine();
            Console.WriteLine("Pleace enter number of items:");
            int num = Convert.ToInt32(Console.ReadLine());

            var allUsers = userManager?.GetAllUsers();
            var userIdByLogin = allUsers.FirstOrDefault(User => User.Login == login);
            Guid needUserId = userIdByLogin.Id;

            var allItems = itemManager.GetItemsList();
            var idByLogin = allItems.FirstOrDefault(Item => Item.Title == title);
            Guid needItemsId = idByLogin.Id;

            var order = new Order
            {
                UserId = needUserId,
                ItemId = needItemsId,
                NumberOfItems = num,
                OrderStatus = OrderStatus.New
            };

            var isOrdered = orderManager.CreateOrder(order);

            if (isOrdered)
            {
                return order;
            }
            return null;
        }

        /// <summary>
        /// User interface of canceling order
        /// </summary>
        /// <returns></returns>
        public bool CancelOrderUI()
        {
            Console.WriteLine("Pleace, enter id of your oder");
            string stringGuid = Console.ReadLine();
            Guid newGuid = Guid.Parse(stringGuid);
            Order order = orderRepository.GetById(newGuid);
            orderManager.CancelOrder(order);
            Console.WriteLine("Order is canceled");
            return true;
        }
       
    }
}
