using WebShop.Common.Models;

namespace WebShop
{
    /// <summary>
    /// Order manager user interface
    /// </summary>
    public interface IOrderManagerUI
    {
        Order CreateNewOrder();
        bool CancelOrderUI();
    }
}