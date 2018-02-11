using System.Collections.Generic;
using System.IO;

namespace MidtermProject.Classes
{
    class CoffeeMenu
    {
        public List<CoffeeObj> Items { get; set; }
        public List<string> CoffeeNames { get; set; }

        public CoffeeMenu()
        {
            PullCoffeeNames();
            Items = new List<CoffeeObj>
            {
                new CoffeeObj(CoffeeNames[0], 1.50D),
                new CoffeeObj(CoffeeNames[1], .99D),
                new CoffeeObj(CoffeeNames[2], 3.50D),
                new CoffeeObj(CoffeeNames[3], 4.00D),
                new CoffeeObj(CoffeeNames[4], 4.25D),
                new CoffeeObj(CoffeeNames[5], 3.50D),
                new CoffeeObj(CoffeeNames[6], 3.75D),
                new CoffeeObj(CoffeeNames[7], 4.00D),
                new CoffeeObj(CoffeeNames[8], 2.00D),
                new CoffeeObj(CoffeeNames[9], 3.50D),
                new CoffeeObj(CoffeeNames[10], 3.00D),
                new CoffeeObj(CoffeeNames[11], 4.00D),
            };
            CoffeeNames = null;
        }
        private void PullCoffeeNames()
        {
            StreamReader read = new StreamReader("../../App/Classes/TextFile1.txt");

            string currentLine = read.ReadLine();
            CoffeeNames = new List<string>();
            while (currentLine != null)
            {
                CoffeeNames.Add(currentLine);
                currentLine = read.ReadLine();
            }
            read.Close();
        }
    }
}
