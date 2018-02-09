using System;
using System.Collections.Generic;
using System.Text;
//adding "using MidtermProject." so that we can access the new interfaces we created in the folder hierarchy
using MidtermProject.Interfaces;
using MidtermProject.Enums;
using MidtermProject.Classes;

namespace MidtermProject.Classes
{
    class PmtCreditCard : IPayments
    {
        //will hold cc type (cctype enum), amount, account number

        public double Amount { get; set; }
        public long CCNumber { get; set; }
        public int SecurityNum { get; set; }
        public DateTime Exp { get; set; }
        public string Name { get; set; }

        public PmtCreditCard(double amount, long ccNumber,int securityNum,DateTime exp,string name)
        {
            Amount = amount;
            CCNumber = ccNumber;
            SecurityNum = securityNum;
            Exp = exp;
            Name = name;
        }
    }
}
