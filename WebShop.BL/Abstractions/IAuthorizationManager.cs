
using WebShop.Common.Models;

namespace WebShop.BL.Abstractions
{
    /// <summary>
    /// Interface that responds of autorization business logic
    /// </summary>
    public interface IAuthorizationManager
    {
        bool RegisterUser(User user);

        User Login(string login, string password);
    }
}
