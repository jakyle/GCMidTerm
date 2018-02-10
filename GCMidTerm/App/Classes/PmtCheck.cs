using System;
using System.Collections.Generic;
using System.Text;
//adding "using MidtermProject." so that we can access the new interfaces we created in the folder hierarchy
using MidtermProject.Interfaces;
using MidtermProject.Enums;
using MidtermProject.Classes;

namespace MidtermProject.Classes
{
    class PmtCheck : IPayments
    {
        //will hold check number, check amount, routing number, account number

        double IPayments.Amount { get; set; }
        public long AccountNumber { get; set; } 
        long RountingNumber { get; set; }
        int CheckNumber { get; set; }

        //CONSTRUCTOR
    }
}
