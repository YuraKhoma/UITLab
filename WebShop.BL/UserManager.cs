using System.Collections.Generic;
using WebShop.BL.Abstractions;
using WebShop.Common.Models;
using WebShop.DataAccess.Abstractions;

namespace WebShop.BL
{
    /// <summary>
    /// Implements IUserManager interface
    /// </summary>
    public class UserManager : IUserManager
    {
        private readonly IUserRepository userRepository;

        public UserManager(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        /// <summary>
        /// Returns list of all items
        /// </summary>
        /// <returns></returns>
        public List<User> GetAllUsers()
        {
            var allItems = userRepository.GetUsers();
            return allItems;
        }

        /// <summary>
        /// Creates buf user
        /// </summary>
        /// <returns></returns>
        public User CreateBufUser()
        { 
            var user = new User
            {
                Role = UserRole.Guest
            };
            userRepository.Create(user);
            return user;
        }

        /// <summary>
        /// Uodates user status
        /// </summary>
        /// <returns></returns>
        public User UpdateToUser()
        {
            var user = new User
            {
                Role = UserRole.User
            };
            userRepository.Create(user);
            return user;
        }
    }
}
