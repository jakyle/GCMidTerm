﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermProject.Utilities
{
    class Validation
    {

        //stop
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
}
