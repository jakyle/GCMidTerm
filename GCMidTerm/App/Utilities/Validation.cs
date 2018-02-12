using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MidtermProject.Utilities
{
    class Validation
    {

        //quit
        public static ConsoleKey YesorNo(string Message)
        {
            Console.WriteLine(Message);
            ConsoleKey Input = Console.ReadKey().Key;
            while (Input != ConsoleKey.Y && Input == ConsoleKey.N)
            {
                Console.WriteLine($"Invalid input, {Message}");
                Input = Console.ReadKey().Key;
            }
            return Input;
        }

        //run
        public static string AnothaOne(string input)
        {
            Regex blah = new Regex(@"^(stop|view menu|view cart|add item|remove item)$");
            Match doop = blah.Match(input);
            while (!doop.Success)
            {

                Console.WriteLine("Wrong");

            }
            return input;



        }

    


        public static string remove(string input)
        {
            Regex blah = new Regex(@"^(\d)$");
            Match doop = blah.Match(input);
            while (!doop.Success)
            {

                Console.WriteLine("Enter Valid Number");

            }
            return input;



        }



    }


}
