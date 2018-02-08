using System;
using System.Collections.Generic;
using System.Text;
//adding "using MidtermProject." so that we can access the new interfaces we created in the folder hierarchy
using MidtermProject.Interfaces;
using MidtermProject.Enums;
using MidtermProject.Classes;

namespace MidtermProject.Classes
{
    class Coffee : IProduct //coffee is an implementation of IProducts
    {
        //FIELDS
        //these below have been implimented from iPayments
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        //new unique fields for Coffee.cs
        public Flavors Flavor { get; set; }
        public Sizes Size { get; set; }
        public Dairy DairyChoice { get; set; }
        public int EspressoAmount { get; set; }

        //constructor: giving value to our properties
        public Coffee(string _productName, string _description, double _price, int _quantity,
            Flavors _flavor, Sizes _size, Dairy _dairyChoice, int _espressoAmount)
        {
            ProductName = _productName;
            Description = _description;
            Price = _price;
            Quantity = _quantity;
            Flavor = _flavor;
            Size = _size;
            DairyChoice = _dairyChoice;
            EspressoAmount = _espressoAmount;
        }


    }
}
