﻿using System;
using System.Collections.Generic;
using System.Text;
//adding "using MidtermProject." so that we can access the new interfaces we created in the folder hierarchy
using MidtermProject.Interfaces;
using MidtermProject.Enums;
using MidtermProject.Classes;
using MidtermProject.Utilities;

namespace MidtermProject
{
    class Program
    {
        
        static void Main(string[] args)
       
        {
            try
            {
                //app goes here
                double PmtCash = 2;
                Console.WriteLine(PmtCash);




            }

            catch (Exception)
            {
                Console.WriteLine("Dead end. You're done here. Stick a fork in it.");
            }

        }
    }
}
