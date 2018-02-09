//adding "using MidtermProject." so that we can access the new interfaces we created in the folder hierarchy

namespace MidtermProject.Interfaces
{
    interface IProduct
    {

        //this is where the coffee will implement from (all products will be based on this class)
        //name, price, quantity

        //PROPERTIES
        string ProductName
        {
            set;
            get;
        }
        double Price
        {
            set;
            get;
        }
        int Quantity
        {
            set;
            get;
        }

    }
}
