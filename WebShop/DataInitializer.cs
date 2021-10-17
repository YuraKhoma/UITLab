using System;
using WebShop.Common.Models;
using WebShop.DataAccess.Abstractions;
namespace WebShop.UI
{
    /// <summary>
    /// Initializes some data
    /// </summary>
    public static class DataInitializer
    {
        /// <summary>
        /// Initializes items
        /// </summary>
        public static void InitItems()
        {
            var itemRepository = InstanceInitializer.ItemRepository;

            var item = new Item
            {
                Id = Guid.NewGuid(),
                Title = "Test"
            };
            var item1 = new Item
            {
                Id = Guid.NewGuid(),
                Title = "Test1"
            };
            var item2 = new Item
            {
                Id = Guid.NewGuid(),
                Title = "Test2"
            };
            var item3 = new Item
            {
                Id = Guid.NewGuid(),
                Title = "Test3"
            };


            itemRepository.Create(item);
            itemRepository.Create(item1);
            itemRepository.Create(item2);
            itemRepository.Create(item3);
        }

        /// <summary>
        /// initializes users
        /// </summary>
        public static void InitUsers()
        {
            var userRepository = InstanceInitializer.UserRepository;

            var user = new User
            {
                Id = Guid.NewGuid(),
                Login = "Test",
                Role = UserRole.Admin
            };
            var user1 = new User
            {
                Id = Guid.NewGuid(),
                Login = "PetraVopap",
                Role = UserRole.User
            };
            var user2 = new User
            {
                Id = Guid.NewGuid(),
                Login = "lazlobiro",
                Role = UserRole.User
            };
            var user3 = new User
            {
                Id = Guid.NewGuid(),
                Login = "denimko"
            };

            userRepository.Create(user);
            userRepository.Create(user1);
            userRepository.Create(user2);
            userRepository.Create(user3);
        }


    }
}
