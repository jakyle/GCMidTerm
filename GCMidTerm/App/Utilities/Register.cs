//adding "using MidtermProject." so that we can access the new interfaces we created in the folder hierarchy
using MidtermProject.Interfaces;
using System.Collections.Generic;

namespace MidtermProject.Classes
{

    /// <summary>
    /// type can be: Class, ValueTypes, enums... anything that can be declared in a namespace
    /// </summary>

    static class Register
    {
        //register must do the following:
        //tally each item chosen from the menu board -- DONE
        //Give the subtotal for all items chosen -- DONE
        //calculate sales tax, and grand total -- DONE
        //Ask for payment type — cash, credit, or check -- DONE
        //For cash, ask for amount tendered and provide change -- DONE
        //For credit, get the credit card number, expiration, and CVV. -- DONE
        //At the end, display a receipt with all items ordered, subtotal, grand total, and appropriate payment info.  --DONE 
        //Return to the original menu for a new order.  -- DONE
        //array or ArrayList to keep track of what’s been ordered -- DONE


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

        public static double MakeChange(double amountTendered, double grandTotal)
        {
            double changeDue = amountTendered - grandTotal;
            return changeDue;
        }

    }
}
