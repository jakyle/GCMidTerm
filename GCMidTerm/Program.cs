//adding "using MidtermProject." so that we can access the new interfaces we created in the folder hierarchy
using MidtermProject.Classes;
using System;

namespace MidtermProject
{
    class Program
    {

        static void Main(string[] args)

        {
            try
            {
                //app goes here
                //calling the RUN method in CoffeeStoreApp class to run program
                CoffeeStoreApp coffeeStore = new CoffeeStoreApp();
                coffeeStore.Run();
            }

            catch (Exception)
            {
                Console.WriteLine("Dead end. You're done here. Stick a fork in it.");
            }

        }
    }
}
