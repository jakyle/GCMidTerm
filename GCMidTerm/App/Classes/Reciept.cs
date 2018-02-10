//adding "using MidtermProject." so that we can access the new interfaces we created in the folder hierarchy
using MidtermProject.Interfaces;
using System;
using System.Collections.Generic;


namespace MidtermProject.Classes
{
    public static class Reciept
    {


        static void Print(PmtCreditCard creditCard, List<IProduct> cart)
        {
            Console.WriteLine(new string('*', 20));
            Console.WriteLine("\nHere is your reciept:\n");
            //---------------------------------------------
            double subTotal = Register.GetSubTotal(cart);
            Console.WriteLine($"subtotal: {subTotal}");
            //---------------------------------------------
            double tax = Register.CalculateSalesTax(subTotal, 0.06);
            Console.WriteLine($"Tax: {tax}");
            //---------------------------------------------
            double grandTotal = Register.GetGrandTotal(subTotal, tax);
            Console.WriteLine($"Grand Total: {grandTotal}\n");
            //---------------------------------------------
            Console.WriteLine($"CardNO: {creditCard.CCNumber}");
            Console.WriteLine($"ExpirateionDate: {creditCard.Exp}");
            Console.WriteLine($"ExpirateionDate: {creditCard.SecurityNum}\n");
            //---------------------------------------------
            Console.WriteLine("\nThank you! Please come again!\n");
            Console.WriteLine(new string('*', 20));
        }

        static void Print(PmtCheck check, List<IProduct> cart)
        {
            Console.WriteLine(new string('*', 20));
            Console.WriteLine("\nHere is your reciept:\n");
            //---------------------------------------------
            double subTotal = Register.GetSubTotal(cart);
            Console.WriteLine($"subtotal: {subTotal}");
            //---------------------------------------------
            double tax = Register.CalculateSalesTax(subTotal, 0.06);
            Console.WriteLine($"Tax: {tax}");
            //---------------------------------------------
            double grandTotal = Register.GetGrandTotal(subTotal, tax);
            Console.WriteLine($"Grand Total: {grandTotal}\n");
            //---------------------------------------------
            Console.WriteLine($"ACC-No: {check.AccountNumber}");
            Console.WriteLine($"ROUTING-No: {check.RoutingNumber}\n");
            //---------------------------------------------
            Console.WriteLine("\nThank you! Please come again!\n");
            Console.WriteLine(new string('*', 20));
        }

        static void Print(PmtCash check, List<IProduct> cart)
        {
            Console.WriteLine(new string('*', 20));
            Console.WriteLine("\nHere is your reciept:\n");
            //---------------------------------------------
            double subTotal = Register.GetSubTotal(cart);
            Console.WriteLine($"subtotal: {subTotal}");
            //---------------------------------------------
            double tax = Register.CalculateSalesTax(subTotal, 0.06);
            Console.WriteLine($"Tax: {tax}");
            //---------------------------------------------
            double grandTotal = Register.GetGrandTotal(subTotal, tax);
            Console.WriteLine($"Grand Total: {grandTotal}\n");
            //---------------------------------------------
            Console.WriteLine("All paid in cash!\n");
            //---------------------------------------------
            Console.WriteLine("\nThank you! Please come again!\n");
            Console.WriteLine(new string('*', 20));
        }

    }
}




