using System;
using System.Collections.Generic;
using System.Text;
//adding "using MidtermProject." so that we can access the new interfaces we created in the folder hierarchy
using MidtermProject.Interfaces;
using MidtermProject.Enums;
using MidtermProject.Classes;

namespace MidtermProject.Enums
{
    public enum StoreMenu
    {
        //this will list all the items for the menu

    }
    public enum Coffee
    {
        Black = 1,
        Decaf,
        Latte,
        VanillaLatte,
        CaramelLatte,
        Mocha,
        WhiteChocolateMocha,
        PeppermintMocha,
        DoubleChocolateMocha,
        DoubleHotChocolate,
        HotChocolate,
        PeppermintHotChocolate

    }
    public void Menu()
    {
        //our coffee choice enums
        Console.WriteLine(" Coffee Types");
        Console.WriteLine("--------------");
        Coffee black = Coffee.Black;
        Coffee decaf = Coffee.Decaf;
        Coffee latte = Coffee.Latte;
        Coffee vanillaLatte = Coffee.VanillaLatte;
        Coffee caramelLatte = Coffee.CaramelLatte;
        Coffee mocha = Coffee.Mocha;
        Coffee whiteChocolateMocha = Coffee.WhiteChocolateMocha;
        Coffee peppermintMocha = Coffee.PeppermintMocha;
        Coffee doublechocolatemocha = Coffee.DoubleChocolateMocha;
        Coffee doublehotchocolate = Coffee.DoubleHotChocolate;
        Coffee hotchocolate = Coffee.HotChocolate;
        Coffee pepperminthotchocolate = Coffee.PeppermintHotChocolate;


        //creating coffee objects
        CoffeeObj Black = new CoffeeObj(Coffee.Black.ToString(), 3.50);
        CoffeeObj Decaf = new CoffeeObj(Coffee.Decaf.ToString(), 3.50);
        CoffeeObj Latte = new CoffeeObj(Coffee.Latte.ToString(), 3.50);
        CoffeeObj VanillaLatte = new CoffeeObj(Coffee.VanillaLatte.ToString(), 3.50);
        CoffeeObj CaramelLatte = new CoffeeObj(Coffee.CaramelLatte.ToString(), 3.50);

        CoffeeObj Mocha = new CoffeeObj(Coffee.Mocha.ToString(), 3.50);
        CoffeeObj WhiteChocolateMocha = new CoffeeObj(Coffee.WhiteChocolateMocha.ToString(), 3.50);
        CoffeeObj PeppermintMocha = new CoffeeObj(Coffee.PeppermintMocha.ToString(), 3.50);
        CoffeeObj DoubleChocolateMocha = new CoffeeObj(Coffee.DoubleChocolateMocha.ToString(), 3.50);
        CoffeeObj DoubleHotChocolate = new CoffeeObj(Coffee.DoubleHotChocolate.ToString(), 3.50);
        CoffeeObj HotChocolate = new CoffeeObj(Coffee.HotChocolate.ToString(), 3.50);
        CoffeeObj PeppermintHotChocolate = new CoffeeObj(Coffee.PeppermintHotChocolate.ToString(), 3.50);




    }
}


