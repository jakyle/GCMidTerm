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
        
                // CASH
            case PaymentTypes.cash:  //reference the enum name and then the payment type

                


                // CHECK
                case PaymentTypes.check:     //TO DO - VALIDATION - check number is an integeter
                    Console.WriteLine("Please enter check number"); //assuming they write check for exact amount 

                    int checkNumber = Console.ReadLine();

                    break;

                // CREDIT CARD

                case PaymentTypes.creditCard:   //For credit, get the credit card number, expiration, and CVV.
                    Console.WriteLine("Please enter the credit card number: \n");
                    int ccNum = Console.ReadLine();
                    Console.WriteLine("\nPlease enter the 4-digit expiration date:\n");
                    int ccExp = Console.ReadLine();

                    Console.WriteLine("Please enter the 3-digit CVV (security code\n");
                    int ccSec = Console.ReadLine();
                    break;


            }







            //PROCESS - print reciept

            switch (paymentChoice)
         
            case: cash
            
            //run cash payment method in the reciept class
            break;
            

     
            
       case: check
            //run check payment method in the reciept class
          break;

       
        case creditCard
            
            //run cc payment method in the reciept class
            break;



    //PROCESS - return to menu
}
