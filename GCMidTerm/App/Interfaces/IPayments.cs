﻿using System;
using System.Collections.Generic;
using System.Text;
//adding "using MidtermProject." so that we can access the new interfaces we created in the folder hierarchy
using MidtermProject.Interfaces;
using MidtermProject.Enums;
using MidtermProject.Classes;

namespace MidtermProject.Interfaces
{
    interface IPayments
    {
        // needs hold payment types cash, check, cc, virtual (applepay, paypal etc)

        void Amount();


    }
}

