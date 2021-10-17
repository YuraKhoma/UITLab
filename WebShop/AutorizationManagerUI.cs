using System;
using WebShop.BL.Abstractions;
using WebShop.Common.Models;

namespace WebShop
{
    /// <summary>
    /// Implementation of IAutorizationManagerUI
    /// </summary>
    public class AutorizationManagerUI : IAutorizationManagerUI
    {
        private readonly IAuthorizationManager authorizationManager;

        public AutorizationManagerUI(IAuthorizationManager authorizationManager)
        {
            this.authorizationManager = authorizationManager;
        }

        /// <summary>
        /// User interface of registration
        /// </summary>
        /// <returns></returns>
        public User Register()
        {
            Console.WriteLine("Pleace enter your login:");
            string login = Console.ReadLine();
            Console.WriteLine("Pleace enter your password:");
            string password = Console.ReadLine();

            var user = new User
            {
                Id = Guid.NewGuid(),
                Login = login,
                Role = UserRole.User,
                Password = password
            };

            var isRegistered = authorizationManager.RegisterUser(user);

            if (isRegistered)
            {
                var loggedUser = authorizationManager.Login(user.Login, user.Password);
                return loggedUser;
            }

            return null;
        }

        /// <summary>
        /// User interface of log in
        /// </summary>
        /// <returns></returns>
        public User Login()
        {
            Console.WriteLine("Pleace enter your login:");
            string login = Console.ReadLine();
            Console.WriteLine("Pleace enter your password:");
            string password = Console.ReadLine();

            var user = authorizationManager.Login(login, password);
            return user;
        }
    }
}
