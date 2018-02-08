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

        public void Run()
        {
            Console.WriteLine("Welcome to the grand circus coffee app! what would you like to do?");
            PrintMenu();
        }

        public void Stop()
        {
            Console.WriteLine("would you like to close the program? (press Y to close, N to continue)");
            ConsoleKey answer = Console.ReadKey().Key;
            if (answer == ConsoleKey.Y)
            {
                Console.WriteLine("Thank you for shopping with us, have a good day!");
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

        }
    }
}
