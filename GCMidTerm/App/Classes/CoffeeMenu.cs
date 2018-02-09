using System.Collections.Generic;
using System.IO;

namespace MidtermProject.Classes
{
    class CoffeeMenu
    {
        public List<CoffeeObj> Items { get; set; }

        public CoffeeMenu()
        {
            #region pulls coffee names from .txt
            StreamReader read = new StreamReader("../../App/Classes/TextFile1.txt");

            string currentLine = read.ReadLine();
            List<string> CoffeeName = new List<string>();
            while (currentLine != null)
            {
                CoffeeName.Add(currentLine);
                currentLine = read.ReadLine();
            }
            read.Close();
            #endregion
            #region saves list of coffee with name and price
            Items = new List<CoffeeObj>
            {
                new CoffeeObj(CoffeeName[0], 1.50D),
                new CoffeeObj(CoffeeName[1], .99D),
                new CoffeeObj(CoffeeName[2], 3.50D),
                new CoffeeObj(CoffeeName[3], 4.00D),
                new CoffeeObj(CoffeeName[4], 4.25D),
                new CoffeeObj(CoffeeName[5], 3.50D),
                new CoffeeObj(CoffeeName[6], 3.75D),
                new CoffeeObj(CoffeeName[7], 4.00D),
                new CoffeeObj(CoffeeName[8], 2.00D),
                new CoffeeObj(CoffeeName[9], 3.50D),
                new CoffeeObj(CoffeeName[10], 3.00D),
                new CoffeeObj(CoffeeName[11], 4.00D),
            };
            #endregion
        }
    }
}
