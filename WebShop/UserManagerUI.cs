using System;
using WebShop.BL.Abstractions;
using WebShop.Common.Models;
using WebShop.UI;

namespace WebShop
{
    /// <summary>
    /// Implementation of IUserManagerUI
    /// </summary>
    public class UserManagerUI : IUserManagerUI
    {
        private readonly IUserManager userManager;

        public UserManagerUI(IUserManager userManager)
        {
            this.userManager = userManager;
        }

        /// <summary>
        /// Creates buffer user
        /// </summary>
        /// <returns></returns>
        public User CreateBufUserUI()
        {
            return userManager.CreateBufUser();
        }
    }
}
