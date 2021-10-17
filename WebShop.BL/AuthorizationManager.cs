using WebShop.BL.Abstractions;
using WebShop.Common.Models;
using WebShop.DataAccess.Abstractions;

namespace WebShop.BL
{
    /// <summary>
    /// Implementation of IAutorizationManager
    /// </summary>
    public class AuthorizationManager : IAuthorizationManager
    {
        private readonly IUserRepository userRepository;

        public AuthorizationManager(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        /// <summary>
        /// Logs on users
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public User Login(string login, string password)
        {
            var existingUser = this.userRepository.GetUserByLogin(login);

            if (existingUser == null || existingUser.Password != password)
            {
                return null;
            }

            return existingUser;
        }

        /// <summary>
        /// Registers user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool RegisterUser(User user)
        {
            var existingUser = this.userRepository.GetUserByLogin(user.Login);

            if (existingUser != null || user.Role != UserRole.Guest)
            {
                return false;
            }

            user.Role = UserRole.User;
            this.userRepository.Create(user);
            return true;
        }
    }
}
