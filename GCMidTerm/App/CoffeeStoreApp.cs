using MidtermProject.Enums;
//adding "using MidtermProject." so that we can access the new interfaces we created in the folder hierarchy
using MidtermProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

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
            while (IsRunning)
            {
                Console.WriteLine("Welcome to the grand circus coffee app! what would you like to do?");
                if (Cart.Count < 1)
                {
                    PartialChoices();
                }
                else
                {
                    AppMenuChoices(); //calling menu options
                }
                AppMenu input = (AppMenu)Enum.Parse(typeof(AppMenu), Console.ReadLine());
                InputMenu(input);
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }

        }
        private void AppMenuChoices()
        {
            var menuList = Enum.GetValues(typeof(AppMenu)).Cast<AppMenu>();
            foreach (var item in menuList)
            {
                Console.WriteLine(item);
            }
        }
        private void PartialChoices()
        {
            var menuList = Enum.GetValues(typeof(AppMenu)).Cast<AppMenu>().ToList();
            Console.WriteLine(menuList[1]);
            Console.WriteLine(menuList[menuList.Count - 1]);
        }
        private void InputMenu(AppMenu MenuChoice)
        {
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
            int input = int.Parse(Console.ReadLine()) - 1;
            string itemName = StoreMenu.Items[input].ProductName;
            double itemPrice = StoreMenu.Items[input].Price;
            // ------------------------------------------------------------------------------
            Console.WriteLine("how many do you want?");
            int quantity = int.Parse(Console.ReadLine());

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
            Console.WriteLine($"Your grand total due is: ${String.Format("{0:0.00}", GrandTotal)}");
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
                Console.WriteLine("yo dude, we need more money!: ");
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
            Console.WriteLine("Please input your first and last name: ");
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
        private void Quit() //need implimented
        {
            Console.WriteLine("would you like to close the program? (press Y to close, N to continue)");
            ConsoleKey answer = Console.ReadKey().Key;
            if (answer == ConsoleKey.Y)
            {
                Console.WriteLine("Thank you for shopping with us, have a good day!");
                IsRunning = false;
            }
        }
    }
}