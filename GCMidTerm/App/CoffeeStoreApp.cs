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
                AppMenuChoices(); //calling menu options
                AppMenu input = (AppMenu)Enum.Parse(typeof(AppMenu), Console.ReadLine());
                InputMenu(input);
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

        private void AppMenuChoices()
            //get values is getting enum values
            //cast.appmenu is putting this into an array
        {
            var menuList = Enum.GetValues(typeof(AppMenu)).Cast<AppMenu>();
            foreach (var item in menuList)
            {
                Console.WriteLine(item);
            }
        }

        private void InputMenu(AppMenu MenuChoice)
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
                case AppMenu.removeitem:
                    RemoveItem();
                    break;
                case AppMenu.quit:
                    Stop();
                    break;
            }
        }

        //public void AddItem()
        //{
        //    // DisplayStoreItems();

        //    var input = Console.ReadLine();
        //    int quantity = int.Parse(Console.ReadLine());
        //    if (Cart.Exists(item => item.Name == input))
        //    {
        //        if (Store.TryGetValue(input, out double value))
        //        {
        //            // i don't like that im using soo many iterations to find inputs, does not seem very effective,
        //            // maybe like a O(n*2).. and i do mean n*2 since it seems like im doing a 
        //            // couple loops to do this. 
        //            int location = Cart.FindIndex(item => item.Name == input);
        //            double newVal = value * quantity;

        //            Cart[location].Quantity += quantity;
        //            Cart[location].Price += newVal;
        //        }
        //    }
        //    else if (Store.TryGetValue(input, out double value))
        //    {
        //        Cart.Add(new StoreItem(input, value * quantity, quantity));
        //    }
        //}

        private void ViewCart()
        {
            foreach (IProduct item in Cart)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
