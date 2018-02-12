using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MidtermProject.Utilities
{
    public static class Validation
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

        public static string StoreMenuValidation(string input)
        {
            Regex storeValidateRegex = new Regex(@"^(stop|view menu|view cart|add item|remove item)$");
            Match userInput = storeValidateRegex.Match(input);//users input goes here 
            while (!userInput.Success)
            {
                Console.WriteLine("Please enter valid input.");
            }
            return input;
        }
        public static string Run(string input)
        {
            Regex MenuChoices = new Regex(@"^(stop|view menu|view cart|add item|remove item|1|2|3|4|5)$");
            Match Input = MenuChoices.Match(input);
            while (!Input.Success)

            {
                Console.WriteLine("Please enter valid input.");
            }
            return input;

        }




        //run validations
        public static string remove(string input)
        {
            Regex NumCheck = new Regex(@"^(\d)$");
            Match Input = NumCheck.Match(input);
            while (!Input.Success)
            {
                Console.WriteLine("Enter Valid Number");
            }
            return input;
        }
        #region check //check validation
        public static long Check(long acctNum)
        {

            Regex NumCheck = new Regex("^[0 - 9]{ 2 }\\s[0 - 9]{ 8}$");
            Match Input = NumCheck.Match(acctNum.ToString());
            while (!Input.Success)
            {

                Console.WriteLine("Enter Valid Number");

            }
            return acctNum;

        }

        public static long Check1(long routNum)
        {

            Regex NumCheck = new Regex("^[0 - 9]{ 9 }$");
            Match Input = NumCheck.Match(routNum.ToString());
            while (!Input.Success)
            {

                Console.WriteLine("Enter Valid Number");

            }
            return routNum;

        }

        public static int Check2(int checkNum)
        {

            Regex NumCheck = new Regex("^[0 - 9]{ 4 }$");
            Match Input = NumCheck.Match(checkNum.ToString());
            while (!Input.Success)
            {

                Console.WriteLine("Enter Valid Number");

            }
            return checkNum;

        }

        #endregion
        #region CreditCard //cc validation
        public static long Credit(long creditCardNumber)
        {

            Regex NumCheck = new Regex("^[0-9]{4}\\s[0-9]{4}\\s[0-9]{4}\\s[0-9]{4}$");
            Match Input = NumCheck.Match(creditCardNumber.ToString());
            while (!Input.Success)
            {

                Console.WriteLine("Enter Valid Number");

            }
            return creditCardNumber;

        }

        public static int Credit1(int cvv)
        {

            Regex NumCheck = new Regex("^[0-9]{3}$");
            Match Input = NumCheck.Match(cvv.ToString());
            while (!Input.Success)
            {

                Console.WriteLine("Enter Valid Number");

            }
            return cvv;

        }


        public static DateTime Credit2(DateTime expDate)
        {

            Regex NumCheck = new Regex("(^[0-9]{2}\\/[0-9]{2}$)");
            Match Input = NumCheck.Match(expDate.ToString());
            while (!Input.Success)
            {

                Console.WriteLine("Enter Valid Number");

            }
            return expDate;

        }

        public static int Credit3(int userName)
        {

            Regex NameCheck = new Regex("(^[a-zA-Z]\\s[A-Za-z]$)");
            Match Input = NameCheck.Match(userName);
            while (!Input.Success)
            {

                Console.WriteLine("Enter Valid Number");

            }
            return userName;

        }
        #endregion


        public static long Cash(long amountTendered)
        {

            Regex NumCheck = new Regex("^[0-9]\\.[0-9]{2}$");
            Match Input = NumCheck.Match(amountTendered.ToString());
            while (!Input.Success)
            {

                Console.WriteLine("Enter Valid Number");

            }
            return amountTendered;

        } //cash validations


        public static double AddItem(double amount)
        {

            Regex NumCheck = new Regex("^[0-9]$");
            Match Input = NumCheck.Match(amount.ToString());
            while (!Input.Success)
            {

                Console.WriteLine("Enter Valid Number");

            }
            return amount;

        } //use for both additem validation


        public static PaymentTypes AddItem(PaymentTypes pmtType)
        {

            Regex NumCheck = new Regex("^(cash|credit|check|1|2|3)$");
            Match Input = NumCheck.Match(pmtType.ToString());
            while (!Input.Success)
            {

                Console.WriteLine("Enter Valid Number");

            }
            return pmtType;

        }

        public static int CoffeeValidate(int x)
        {
            //while (x == 0) check ABC / number validation
            //{

            //}
            while ((x < 1) || (x > 12)) //checking users input with coffee options 
            {
                x = 0; //if it's wrong, x is set back to zero (clearing x)
                Console.WriteLine("Please enter a valid choice.");
                x = int.Parse(Console.ReadLine());
            }
            return x;
        }

        public static string YesNo(string x)
        {
            while ((x != "y") && (x != "n")) //checking users input with coffee options "ask to add another item"
            {
                x = ""; //if it's wrong, x it loops back around and clears x

                Console.WriteLine("Please enter either 'y' or 'n': ");
                x = (Console.ReadLine());
            }
            return x;
        }
    }
}
