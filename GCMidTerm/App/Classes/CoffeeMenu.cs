using System.Collections.Generic;
using System.IO;

namespace MidtermProject.Classes
{
    class CoffeeMenu
    {
        public List<CoffeeObj> Items { get; set; }

        public CoffeeMenu()
        {
            StreamReader read = new StreamReader("../../App/Classes/TextFile1.txt");

            string currentLine = read.ReadLine();
            List<string> CoffeeName = new List<string>();
            while (currentLine != null)
            {
                CoffeeName.Add(currentLine);
                currentLine = read.ReadLine();
            }
            read.Close();

            Items = new List<CoffeeObj>
            {
                new CoffeeObj()
            }
        }
    }
}
