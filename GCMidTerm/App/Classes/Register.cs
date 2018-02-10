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


        public decimal GetSubTotal()
        {
        //where is the object for the order? this shouldn't pull from the menu, but the selected objects should be saved to a new variable/array and I pull info from there

            foreach (CoffeeObj in arrayTBD) 
                {
                decimal subtotal = ProductName * Price * Quantity; //update with correct var names

                }
            return subtotal;

        }


        public decimal CalculateSalesTax() 
        {
            decimal salesTaxRate = 0.06;
            decimal salesTaxAmount = salesTaxRate * subtotal;
            return salesTaxAmount;
        }

        public decimal GetGrandTotal()
        {
           
            decimal grandTotal = subtotal + salesTaxAmount;
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
                case cash:     
           
                Console.WriteLine("Please enter the amount of cash you are paying with:");
                decimal pmtAmt = Console.ReadLine();

                decimal giveChange = pmtAmt - grandTotal;
                return giveChange;        
                break;


            // CHECK
                case check:     //TO DO - VALIDATION - check number is an integeter
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
