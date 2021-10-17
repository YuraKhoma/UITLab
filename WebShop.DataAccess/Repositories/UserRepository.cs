using System.Collections.Generic;
using System.Linq;
using WebShop.Common.Models;
using WebShop.DataAccess.Abstractions;

namespace WebShop.DataAccess.Repositories
{
    /// <summary>
    /// Implementetion of IUserRepository
    /// </summary>
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        /// <summary>
        /// Finds and returns user by login
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public User GetUserByLogin(string login)
        {
            var user = storage.FirstOrDefault(x => x.Login == login);
            return user;
        }

        /// <summary>
        /// Returns list of users
        /// </summary>
        /// <returns></returns>
        public List<User> GetUsers()
        {
            return storage.Where(x => x.Role != UserRole.Guest).ToList();
        }
    }
}
