using System;
using System.Collections.Generic;
using System.Text;
//adding "using MidtermProject." so that we can access the new interfaces we created in the folder hierarchy
using MidtermProject.Interfaces;
using MidtermProject.Enums;
using MidtermProject.Classes;

namespace MidtermProject.Classes
{
    static class Register
    {
        //register must do the following:
        //tally each item chosen from the menu board 
        //Give the subtotal for all items chosen -- DONE
        //calculate sales tax, and grand total -- DONE
        //Ask for payment type — cash, credit, or check -- DONE
        //For cash, ask for amount tendered and provide change -- DONE
        //For check, get the check number -- DONE
        //For credit, get the credit card number, expiration, and CVV. -- DONE
        //At the end, display a receipt with all items ordered, subtotal, grand total, and appropriate payment info.
        //Return to the original menu for a new order.  
        //Hint: you’ll want an array or ArrayList to keep track of what’s been ordered! -- ** WHERE IS THE ORDER THAT THE CUSTOMER PLACED? **


        //METHODS - calculate subtotal and grand total 


        public static double GetSubTotal(List<IProduct> Cart)  //pass the list into the GetSubTotal method
        {
            double subtotal = 0;

            foreach (IProduct item in Cart) //for each element in the cart, store in a temporary value called item
            {
                subtotal += item.Price;

            }
            return subtotal;

        }


        public static double CalculateSalesTax(double subtotal, double salesTaxRate)  //use subtotal as the argument
        {
            double salesTaxAmount = salesTaxRate * subtotal;
            return salesTaxAmount;
        }

        public static double GetGrandTotal(double subtotal, double salesTaxAmount)
        {

            double grandTotal = subtotal + salesTaxAmount;
            return grandTotal;

        }


        //PROCESS - select payment type


        public static void GetPaymentType(PaymentTypes PmtType)  //PmtType is a temporary variable
        {
            switch (PmtType)
            {

                // CASH
                case PaymentTypes.cash:
                    PaymentCash();

                    break;

                case PaymentTypes.creditCard:
                    PaymentCreditCard();

                    break;
                case PaymentTypes.check:
                    PaymentCheck();

                    break;
            }
        }
        private static void PaymentCash()
        {
            Console.WriteLine("Enter total payment due: ");
            double cashAmount = double.Parse(Console.ReadLine()); //setting variable for user's cash amount
            PmtCash cash = new PmtCash(cashAmount); //making new cash object with cash class

        }

        private static void PaymentCheck()
        {
            Console.WriteLine("Enter total payment due: ");
            double checkAmount = double.Parse(Console.ReadLine()); //setting variable for user's cash amount
            PmtCheck check = new PmtCheck(); //making new cash object with cash class

        }

        private static void PaymentCreditCard()
        {
            //getting information from constructor to save CC Info
            Console.WriteLine("Enter total payment due: ");
            double creditCard = double.Parse(Console.ReadLine()); //setting variable for user's cash amount
            Console.WriteLine("Please enter credit card number: ");
            double creditCardNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter CVV code: ");
            int cvv = int.Parse(Console.ReadLine());

            //datetime
            Console.WriteLine("Please input your first and last name: ");
            string userName = Console.ReadLine();

            PmtCreditCard credit = new PmtCreditCard(creditCard, creditCardNumber, cvv, userName); //making new cash object with cash class
        }
    }
}
