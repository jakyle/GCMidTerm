//adding "using MidtermProject." so that we can access the new interfaces we created in the folder hierarchy
using MidtermProject.Interfaces;

namespace MidtermProject.Classes
{
    class PmtCheck : IPayments
    {
        //will hold cc type (cctype enum), amount, account number

        public double Amount { get; set; }
        public long AccountNumber { get; set; }
        public long RoutingNumber { get; set; }
        public int CheckNumber { get; set; }

        public PmtCheck(double amount, long accountNumber, long routingNumber, int checkNumber)
        {
            Amount = amount;
            AccountNumber = accountNumber;
            RoutingNumber = routingNumber;
            CheckNumber = checkNumber;
        }
    }
}
