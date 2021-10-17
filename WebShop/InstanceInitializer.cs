using WebShop.BL;
using WebShop.BL.Abstractions;
using WebShop.DataAccess.Abstractions;
using WebShop.DataAccess.Repositories;

namespace WebShop.UI
{
    /// <summary>
    /// Initialization of some clasess objects 
    /// </summary>
    public static class InstanceInitializer
    {
        private static IUserRepository userRepository;
        private static IItemRepository itemRepository;
        private static IItemManager itemManager;
        private static IAuthorizationManager authorizationManager;
        private static IItemManagerUI itemManagerUI;
        private static IAutorizationManagerUI autorizationManagerUI;
        private static IOrderManager orderManager;
        private static IOrderManagerUI orderManagerUI;
        private static IOrderRepository orderRepository;
        private static IUserManager userManager;
        private static IUserManagerUI userManagerUI;

        /// <summary>
        /// Service Locator pattern
        /// </summary>
        static InstanceInitializer()
        {
            userRepository = new UserRepository();
            itemRepository = new ItemRepository();
            orderRepository = new OrderRepository();
            itemManager = new ItemManager(itemRepository);
            authorizationManager = new AuthorizationManager(userRepository);
            itemManagerUI = new ItemManagerUI(itemManager);
            autorizationManagerUI = new AutorizationManagerUI(authorizationManager);
            orderManager = new OrderManager(orderRepository);
            orderManagerUI = new OrderManagerUI(orderManager);
            userManager = new  UserManager(userRepository);
            userManagerUI = new UserManagerUI(userManager);
        }


        public static IUserRepository UserRepository => userRepository;
        public static IItemRepository ItemRepository => itemRepository;
        public static IItemManager ItemManager => itemManager;
        public static IAuthorizationManager AuthorizationManager => authorizationManager;
        public static IAutorizationManagerUI AutorizationManagerUI => autorizationManagerUI;
        public static IItemManagerUI ItemManagerUI => itemManagerUI;
        public static IOrderManager OrderManager => orderManager;
        public static IOrderManagerUI OrderManagerUI => orderManagerUI;
        public static IOrderRepository OrderRepository => orderRepository;
        public static IUserManager UserManager => userManager;
        public static IUserManagerUI UserManagerUI => userManagerUI;
    }
}
