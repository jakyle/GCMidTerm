//adding "using MidtermProject." so that we can access the new interfaces we created in the folder hierarchy
using MidtermProject.Interfaces;
using System;
using System.Collections.Generic;


namespace MidtermProject.Classes
{
    static class Reciept
    {

        public static void Print(PmtCreditCard creditCard, List<IProduct> cart)
        {
            Console.WriteLine(new string('*', 25));
            Console.WriteLine("\nHere is your reciept:\n");
            //---------------------------------------------
            double subTotal = Register.GetSubTotal(cart);
            Console.WriteLine($"subtotal: ${string.Format("{0:0.00}", subTotal)}");
            //---------------------------------------------
            double tax = Register.CalculateSalesTax(subTotal, 0.06);
            Console.WriteLine($"Tax: ${string.Format("{0:0.00}", tax)}");
            //---------------------------------------------
            double grandTotal = Register.GetGrandTotal(subTotal, tax);
            Console.WriteLine($"Grand Total: ${string.Format("{0:0.00}", grandTotal)}\n");
            #region extrastuff
            //---------------------------------------------
            Console.WriteLine($"CardNO: {creditCard.CCNumber}");
            Console.WriteLine($"ExpirateionDate: {creditCard.Exp}");
            Console.WriteLine($"SecurtyNumber: {creditCard.SecurityNum}\n");
            Console.WriteLine("You've been hacked... wrecked.. easy...");
            //---------------------------------------------
            Console.WriteLine("\nThank you! Please come again!\n");
            #endregion extrastuff
            Console.WriteLine(new string('*', 25));
        }

        public static void Print(PmtCheck check, List<IProduct> cart)
        {
            Console.WriteLine(new string('*', 25));
            Console.WriteLine("\nHere is your reciept:\n");
            //---------------------------------------------
            double subTotal = Register.GetSubTotal(cart);
            Console.WriteLine($"subtotal: ${string.Format("{0:0.00}", subTotal)}");
            //---------------------------------------------
            double tax = Register.CalculateSalesTax(subTotal, 0.06);
            Console.WriteLine($"Tax: ${string.Format("{0:0.00}", tax)}");
            //---------------------------------------------
            double grandTotal = Register.GetGrandTotal(subTotal, tax);
            Console.WriteLine($"Grand Total: ${string.Format("{0:0.00}", grandTotal)}\n");
            //---------------------------------------------
            Console.WriteLine($"ACC-No: {check.AccountNumber}");
            Console.WriteLine($"ROUTING-No: {check.RoutingNumber}\n");
            //---------------------------------------------
            Console.WriteLine("\nThank you! Please come again!\n");
            Console.WriteLine(new string('*', 25));
        }

        public static void Print(PmtCash cash, List<IProduct> cart, double amountTendered)
        {
            Console.WriteLine(new string('*', 25));
            Console.WriteLine("\nHere is your reciept:\n");
            //---------------------------------------------
            double subTotal = Register.GetSubTotal(cart);
            Console.WriteLine($"subtotal: ${string.Format("{0:0.00}", subTotal)}");
            //---------------------------------------------
            double tax = Register.CalculateSalesTax(subTotal, 0.06);
            Console.WriteLine($"Tax: ${string.Format("{0:0.00}", tax)}");
            //---------------------------------------------
            double grandTotal = Register.GetGrandTotal(subTotal, tax);
            Console.WriteLine($"Grand Total: ${string.Format("{0:0.00}", grandTotal)}\n");
            //---------------------------------------------
            double changeDue = Register.MakeChange(amountTendered, grandTotal);
            Console.WriteLine("All paid in cash!\n");
            Console.WriteLine($"your change is ${String.Format("{0:0.00}", changeDue)}");
            //---------------------------------------------
            Console.WriteLine("\nThank you! Please come again!\n");
            Console.WriteLine(new string('*', 25));
        }
    }
}




