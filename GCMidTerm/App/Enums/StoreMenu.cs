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




        //Coffee Latte = new Coffee("Latte", "Fresh espresso with your choice of non-fat, regular, or soy milk", 3.50);

        //Coffee Mocha = new Coffee("Mocha", "Fresh espresso, cocoa, ground chocolate, topped with your choice of steamed non-fat, regular, or soy milk.", 3.50);



    }
}


