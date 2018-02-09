using System;
using System.Collections.Generic;
using System.Text;
//adding "using MidtermProject." so that we can access the new interfaces we created in the folder hierarchy
using MidtermProject.Interfaces;
using MidtermProject.Enums;
using MidtermProject.Classes;

namespace MidtermProject.Classes
{
    class Register
    {


        //register must do the following:
        //tally each item chosen from the menu board
        //Give the subtotal for all items chosen -- KINDA DONE
        //calculate sales tax, and grand total -- DONE
        //Ask for payment type — cash, credit, or check -- DONE
        //For cash, ask for amount tendered and provide change -- DONE
        //For check, get the check number -- DONE
        //For credit, get the credit card number, expiration, and CVV. -- DONE
        //At the end, display a receipt with all items ordered, subtotal, grand total, and appropriate payment info.
        //Return to the original menu for a new order.  (Hint: you’ll want an array or ArrayList to keep track of what’s been ordered!)


        //METHODS - calculate subtotal and grand total 


        public void CalculateSubTotal()
        {
            foreach item in menu //update with correct var name for item and menu
                {
                double subtotal = itemName * itemPrice * itemQty //update with correct var names

                }
            return subtotal;

        }


        public double GetGrandTotal()  //add tax and get grand total 
        {
            double salesTaxRate = 1.06;
            double grandTotal = salesTaxRate *= subtotal;
            return grandTotal;

        }


        //PROCESS - select payment type


        public void GetPaymentType()
        {
            Console.WriteLine("How would you like to pay for your order? \n [1]Cash, [2]Check or [3]Card? ");
            String PaymentChoice = Console.ReadLine();  //TO DO - add validation for this user input to allow numerical choice or written
        }
        
       

        switch (PaymentChoice)
            {

                // CASH
                case cash:     //For cash, ask for amount tendered and provide change. 
           
                Console.WriteLine("Please enter the amount of cash you are paying with:");
                double pmtAmt = Console.ReadLine();

        double giveChange = pmtAmt - grandTotal;


        
                break;


            // CHECK
            case check:     //For check, get the check number      //TO DO - VALIDATION - check number is an integeter
                 Console.WriteLine("Please enter check number"); //assuming they write check for exact amount 
      
            int checkNumber = Console.ReadLine();
                    
                break;   
        
        // CREDIT CARD

        case creditCard:   //For credit, get the credit card number, expiration, and CVV.
         Console.WriteLine("Please enter the credit card number: \n");
           int ccNum = Console.ReadLine();
        Console.WriteLine("\nPlease enter the 4-digit expiration date:\n" );
            int ccExp = Console.ReadLine();

        Console.WriteLine("Please enter the 3-digit CVV (security code\n");
            int ccSec = Console.ReadLine();
        break;
    




    //PROCESS - print reciept

//create method to print reciept and use overrides? or just do it here?

    if (PaymentType == cash)
    {
            Console.WriteLine($"Here is your change: ${giveChange}.");  
            Console.WriteLine("Here is your reciept:");

   
//need method to generate reciept for each type. then invoke the method here in the register. 


    Console.WriteLine("Thank you! Please come again!);
    }

    //PROCESS - return to menu
    //call the method? is this the only place we will return to menu? 
}
