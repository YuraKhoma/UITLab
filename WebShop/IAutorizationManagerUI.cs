using WebShop.Common.Models;

namespace WebShop
{

    /// <summary>
    /// Autorization manager user interface
    /// </summary>
    public interface IAutorizationManagerUI
    {
        User Login();
        User Register();
    }
}