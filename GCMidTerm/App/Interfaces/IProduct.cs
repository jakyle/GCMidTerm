using System;
using System.Collections.Generic;
using System.Text;
//adding "using MidtermProject." so that we can access the new interfaces we created in the folder hierarchy
using MidtermProject.Interfaces;
using MidtermProject.Enums;
using MidtermProject.Classes;

namespace MidtermProject.Interfaces
{
    interface IProduct
    {

        //this is where the coffee will implement from (all products will be based on this class)
        //description, price, qty

        //PROPERTIES
        string ProductName
        {
            set;
            get;
        }
        string Description
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
