using System;
using System.Collections.Generic;
using System.Text;
//adding "using MidtermProject." so that we can access the new interfaces we created in the folder hierarchy
using MidtermProject.Interfaces;
using MidtermProject.Enums;
using MidtermProject.Classes;
using MidtermProject.Utilities;
using System.Linq;

namespace MidtermProject.Classes
{
    class CoffeeStoreApp : IApp
    {
        //what the user will see and interact with (user interface)
        //will pull data and methods from other classes

        //menu items, add/remove items, etc
        public bool IsRunning { get; set; } = true;
        public List<IProduct> Cart { get; set; } = new List<IProduct>();
        public AppMenu MenuChoice { get; set; }

        public void Run()
        {
            while (IsRunning == true)
            {
                Console.WriteLine("Welcome to the grand circus coffee app! what would you like to do?");
                PrintMenu();
                var input = Console.ReadLine();
                if (input == AppMenu.quit)
                {
                    Stop();
                }
            }
            
        }

        public void Stop()
        {
            Console.WriteLine("would you like to close the program? (press Y to close, N to continue)");
            ConsoleKey answer = Console.ReadKey().Key;
            if (answer == ConsoleKey.Y)
            {
                Console.WriteLine("Thank you for shopping with us, have a good day!");
                IsRunning = false;
            }
        }

        private void PrintMenu()
        {
            IEnumerable<StoreMenu> Menus = Enum.GetValues(typeof(StoreMenu)).Cast<StoreMenu>();
            foreach (StoreMenu Menu in Menus)
            {
                Console.WriteLine($"[{(int)Menu}]. {Menu}");
            }
        }

        private void InputMenu()
        {
            switch (MenuChoice)
            {
                case AppMenu.viewmenu:
                    PrintMenu();
                    break;
                case AppMenu.viewcart:
                    ViewCart();
                    break;
                case AppMenu.additem:
                    AddItem();
                    break;
            }
        }

        private void AddItem()
        {
            // Take user input, user decides what item he wants to add
            // item name,
            // htne we will figure out the price
            // we will ask the user the payment type
            // then we wll figure out hte taxes,
            // the grand total,
            // etc etc.
        }

        private void ViewCart()
        {
            foreach (IProduct item in Cart)
            {
                Console.WriteLine($"");
            }
        }
    }
}
