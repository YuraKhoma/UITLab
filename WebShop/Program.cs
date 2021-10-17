using System;
using WebShop.UI;

namespace WebShop
{
    static class Program
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            DataInitializer.InitItems();
            var authManagerUi = InstanceInitializer.AutorizationManagerUI;
            var itemManagerUi = InstanceInitializer.ItemManagerUI;
            var orderManagerUi = InstanceInitializer.OrderManagerUI;
            var userManagerUi = InstanceInitializer.UserManagerUI;

            userManagerUi.CreateBufUserUI();
            while (true)
            {
                Console.WriteLine("Hi! What do you want to do?");
                Console.WriteLine("1 - See all goods");
                Console.WriteLine("2 - Find goods by Name ");
                Console.WriteLine("3 - Register");
                Console.WriteLine("4 - Sing in");
                Console.WriteLine("5 - Create order");
                Console.WriteLine("7 - Cancel orer");
                Console.WriteLine("16 - Exit");

                uint action = Convert.ToUInt32(Console.ReadLine());

                switch (action)
                {
                    case 1:
                        itemManagerUi.PrintAllItems();
                        break;
                    case 2:
                        itemManagerUi.FindByNameUI();
                        break;
                    case 3:
                        authManagerUi.Register();
                        break;
                    case 4:
                        authManagerUi.Login();
                        break;
                    case 5:
                        orderManagerUi.CreateNewOrder();
                        break;
                    case 7:
                        orderManagerUi.CancelOrderUI();
                        break;

                    case 16:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong number of operaton. Try again");
                        break;
                }
            }
        }
    }
}
