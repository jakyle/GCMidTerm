using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//adding "using MidtermProject." so that we can access the new interfaces we created in the folder hierarchy
using MidtermProject.Interfaces;
using MidtermProject.Enums;
using MidtermProject.Classes;


namespace MidtermProject.Classes
{
    class Reciept
    {
        public static string PrintReceipt();
        {
              Console.WriteLine(new string ('*',20)); 


             Console.WriteLine("\nHere is your reciept:\n");
            //add ProductName, Price, Quantity, Subtotal, SalesTax, GrandTotal

            //switch: PaymentChoice
            //run the method for each payment info entered in the register (cash, check, cc)
                
            Console.WriteLine("\nThank you! Please come again! \n");
            Console.WriteLine(new string ('*',20));
    

//create method to generate payment info for each type. then invoke the method in the register. 



        switch  (PaymentChoice)
   
        case cash;
        Console.WriteLine($"Here is your change: ${giveChange}.");  
        break;   
      

        case: creditCard
        Console.WriteLine($"Paid with {creditCard}");
        break;   

        case: check
        Console.WriteLine($"Paid with {check});
        break;
    }
    }
}




