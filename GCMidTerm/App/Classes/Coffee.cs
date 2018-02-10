//adding "using MidtermProject." so that we can access the new interfaces we created in the folder hierarchy
using MidtermProject.Interfaces;
using System;

namespace MidtermProject.Classes
{
    class CoffeeObj : IProduct //coffee is an implementation of IProducts
    {
        //FIELDS
        //these below have been implimented from iPayments
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public CoffeeObj(string _productName, double _price)
        {
            ProductName = _productName;
            Price = _price;
        }

        public CoffeeObj(string _productName, double _price, int _qty)
        {
            ProductName = _productName;
            Price = _price;
            Quantity = _qty;
        }

        public override string ToString()
        {
            return $"{ProductName}\t\t...${String.Format("{0:0.00}", Price)}\tQty: {Quantity}";
        }

    }
}
