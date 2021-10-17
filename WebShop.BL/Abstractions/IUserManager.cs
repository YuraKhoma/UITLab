using System.Collections.Generic;
using WebShop.Common.Models;

namespace WebShop.BL.Abstractions
{
    /// <summary>
    /// Responds of user business logic
    /// </summary>
    public interface IUserManager
    {
        List<User> GetAllUsers();
        public User CreateBufUser();
    }
}
