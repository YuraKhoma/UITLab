using System.Collections.Generic;
using WebShop.Common.Models;

namespace WebShop.DataAccess.Abstractions
{
    /// <summary>
    /// Base user interface
    /// </summary>
    public interface IUserRepository : IRepository<User>
    {
        User GetUserByLogin(string login);

        List<User> GetUsers();
    }
}
