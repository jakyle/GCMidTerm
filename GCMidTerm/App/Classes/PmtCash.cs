using System;
using System.Collections.Generic;
using System.Text;
//adding "using MidtermProject." so that we can access the new interfaces we created in the folder hierarchy
using MidtermProject.Interfaces;
using MidtermProject.Enums;
using MidtermProject.Classes;

namespace MidtermProject.Classes
{
    class PmtCash : IPayments
    {
        //holds the amount for cash transactions

        //PROPERTIES
        public double Amount
        {
            get;
            set;

        }

        //METHODS


        //CONSTRUCTORS
        public PmtCash (double Amount)
        {
            this.Amount = Amount;
        }

        
    }
}
