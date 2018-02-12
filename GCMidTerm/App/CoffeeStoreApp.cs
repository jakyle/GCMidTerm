using MidtermProject.Enums;
//adding "using MidtermProject." so that we can access the new interfaces we created in the folder hierarchy
using MidtermProject.Interfaces;
using MidtermProject.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Configuration;

namespace MidtermProject.Classes
{
    class CoffeeStoreApp : IApp
    {
        //what the user will see and interact with (user interface)
        //will pull data and methods from other classes

        //menu items, add/remove items, etc
        public bool IsRunning { get; set; } = true;
        public bool UserPaidCash { get; set; } = false;
        public bool UserPaidCredit { get; set; } = false;
        public bool UserPaidCheck { get; set; } = false;
        public double SubTotal { get; set; }
        public double Tax { get; set; }
        public double GrandTotal { get; set; }
        public CoffeeMenu StoreMenu { get; } = new CoffeeMenu();
        public List<IProduct> Cart { get; set; } = new List<IProduct>();
        public IPayments UserPayment { get; set; }
        public double CashAmount { get; set; }

        public void Run()
        {
            while (IsRunning == true)
            {
                Console.WriteLine("Welcome to the Grand Circus Coffee App! May I take your order?");
                if (Cart.Count < 1)
                {
                    PartialChoices();
                }
                else
                {
                    AppMenuChoices(); //calling menu options - view menu/quit
                }
                AppMenu input = (AppMenu)Enum.Parse(typeof(AppMenu), Console.ReadLine());
                InputMenu(input);
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                Console.Clear();
            }
        }
        private void AppMenuChoices()
        {
            var menuList = Enum.GetValues(typeof(AppMenu)).Cast<AppMenu>();
            foreach (var item in menuList)
            {
                Console.WriteLine($"[{(int)item}]. {item}"); //casting int to item so enum shows both the number value and the string name
            }
        }
        private void PartialChoices()
        {
            var menuList = Enum.GetValues(typeof(AppMenu)).Cast<AppMenu>().ToList();
            Console.WriteLine(menuList[1]);
            Console.WriteLine(menuList[menuList.Count - 1]);
        }
        private void InputMenu(AppMenu MenuChoice) //input menu here 
        {
            //validation
            switch (MenuChoice)
            {
                case AppMenu.viewcart:
                    ViewCart();
                    break;
                case AppMenu.viewmenu:
                    AddItem();
                    break;
                case AppMenu.removeitem:
                    RemoveItem();
                    break;
                case AppMenu.checkout:
                    Checkout();
                    break;
                case AppMenu.quit:
                    Quit();
                    break;
            }
        }
        private void DisplayStoreItems()
        {
            int acc = 1;
            foreach (CoffeeObj item in StoreMenu.Items) //getting menu items from list, displaying to console w/ price
            {
                Console.WriteLine($"[{acc}]. {item.ProductName}\t\t\t\t${String.Format("{0:0.00}", item.Price)}");
                acc++;
            }
        }
        private void ViewCart()
        {
            int acc = 1;
            foreach (IProduct item in Cart)
            {
                Console.WriteLine($"{acc}. {item}");
                acc++;
            }
        }
        private void AddItem() //need 2
        {
            DisplayStoreItems();

            Console.WriteLine("Which coffee would you like to purchase? enter the number in between the \"[ ] \"");
            int input = int.Parse(Console.ReadLine()); //validate abc

            //call validation
            input = Validation.CoffeeValidate(input);  //the new input value is now being stored

            string itemName = StoreMenu.Items[input].ProductName;
            double itemPrice = StoreMenu.Items[input].Price;
            // ------------------------------------------------------------------------------
            Console.WriteLine("how many do you want?");
            int quantity = int.Parse(Console.ReadLine()); //validate number


            // this if statement figures out if the item already exist inside of the
            // the cart, if it does, it will update the price and the quantity
            if (Cart.Exists(item => item.ProductName == itemName))
            {
                // item location in cart
                int location = Cart.FindIndex(item => item.ProductName == itemName);

                // price of item 
                double newVal = itemPrice * quantity;
                Cart[location].Quantity += quantity;
                Cart[location].Price += newVal;
            }
            else
            {
                Cart.Add(new CoffeeObj(itemName, itemPrice * quantity, quantity));
            }

            //ASK TO ADD ANOTHER ITEM //
            Console.WriteLine("\nWould you like to add another item? y/n");
            string addAnotherItem = Console.ReadLine();

            addAnotherItem = Validation.YesNo(addAnotherItem);

            if (addAnotherItem == "y")
            {
                AddItem();
            }

            else
            {
                Console.WriteLine("\nDoes this complete your order? y/n");
                ViewCart();
                string orderComplete = Console.ReadLine();

                if (orderComplete == "y")
                {
                    Checkout();
                }

                else
                    Console.WriteLine("Please make another selection");
                AddItem();
            }
        }
        private void RemoveItem() //need one.
        {
            ViewCart();
            Console.WriteLine("Type the name of the item you want to remove.");
            string input = Console.ReadLine();
            int itemLocation = Cart.FindIndex(item => item.ProductName == input);
            Cart.RemoveAt(itemLocation - 1);
        }
        private void Checkout() //need one
        {
            GetTotalAmounts();
            Console.WriteLine($"\nYour grand total is: ${String.Format("{0:0.00}", GrandTotal)}");
            Console.WriteLine("How would you like to pay? ([1].Cash, [2].Credit, [3].Check)");
            PaymentTypes pmtType = (PaymentTypes)Enum.Parse(typeof(PaymentTypes), Console.ReadLine().ToLower());
            GetPaymentType(pmtType);
            Console.WriteLine();
            GetReciept();
            Cart.Clear();
            Quit();
        }
        private void GetPaymentType(PaymentTypes PmtType)  //PmtType is a temporary variable
        {
            switch (PmtType)
            {
                case PaymentTypes.cash:
                    PaymentCash();
                    break;
                case PaymentTypes.credit:
                    PaymentCreditCard();
                    break;
                case PaymentTypes.check:
                    PaymentCheck();
                    break;
            }
        }
        private void GetTotalAmounts()
        {
            // figuring out the grand total for the user
            SubTotal = Register.GetSubTotal(Cart);
            Tax = Register.CalculateSalesTax(SubTotal, 0.06);
            GrandTotal = Register.GetGrandTotal(SubTotal, Tax);
            //--------------------------------------------
        }
        private void PaymentCash() //need two
        {
            Console.WriteLine("Enter amount tendered: ");
            CashAmount = double.Parse(Console.ReadLine());//setting variable for user's cash amount
            while (CashAmount < GrandTotal)
            {
                Console.WriteLine("Yo dude, we need more money! ");
                CashAmount = double.Parse(Console.ReadLine());
            }
            UserPayment = new PmtCash(CashAmount); //making new cash object with cash class
            UserPaidCash = true;
        }
        private void PaymentCheck() //need 3
        {
            Console.WriteLine("Enter account number: ");
            long acctNum = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter routing number: ");
            long routNum = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter check number: ");
            int checkNum = int.Parse(Console.ReadLine());
            UserPayment = new PmtCheck(GrandTotal, acctNum, routNum, checkNum); //making new check object from check class
            UserPaidCheck = true;
        }
        private void PaymentCreditCard() //needs 4
        {
            Console.WriteLine("Enter credit card number: ");
            long creditCardNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter CVV code: ");
            int cvv = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter expiration date: mm/yy");
            DateTime expDate = DateTime.Parse(Console.ReadLine());
            //datetime
            Console.WriteLine("Please enter your first and last name: ");
            string userName = Console.ReadLine();

            UserPayment = new PmtCreditCard(GrandTotal, creditCardNumber, cvv, expDate, userName); //making new credit card object with credit card class
            UserPaidCredit = true;
        }
        private void GetReciept()
        {
            if (UserPaidCash)
                Reciept.Print((PmtCash)UserPayment, Cart, CashAmount);
            if (UserPaidCredit)
                Reciept.Print((PmtCreditCard)UserPayment, Cart);
            if (UserPaidCheck)
                Reciept.Print((PmtCheck)UserPayment, Cart);
            UserPaidCash = false;
            UserPaidCheck = false;
            UserPaidCredit = false;
        }
        private void Quit()
        {
            Console.WriteLine("Would you like to close the program? y/n");
            ConsoleKey answer = Console.ReadKey().Key;
            if (answer == ConsoleKey.Y)
            {
                Console.WriteLine("\nThank you for coming, enjoy your coffee!");
                IsRunning = false;
            }
        }
    }
}