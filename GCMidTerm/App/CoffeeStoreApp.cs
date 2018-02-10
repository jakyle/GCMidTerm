using MidtermProject.Enums;
//adding "using MidtermProject." so that we can access the new interfaces we created in the folder hierarchy
using MidtermProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MidtermProject.Classes
{
    class CoffeeStoreApp : IApp
    {
        //what the user will see and interact with (user interface)
        //will pull data and methods from other classes

        //menu items, add/remove items, etc
        public bool IsRunning { get; set; } = true;
        public List<IProduct> Cart { get; set; } = new List<IProduct>();
        public AppMenu MenuChoice { get; set; }
        public IPayments UserPayment { get; set; }

        public void Run()
        {
            while (IsRunning == true)
            {
                Console.WriteLine("Welcome to the grand circus coffee app! what would you like to do?");
                AppMenuChoices(); //calling menu options
                AppMenu input = (AppMenu)Enum.Parse(typeof(AppMenu), Console.ReadLine());
                InputMenu(input);
            }

        }

        private void AppMenuChoices()
        //get values is getting enum values
        //cast.appmenu is putting this into an array
        {
            var menuList = Enum.GetValues(typeof(AppMenu)).Cast<AppMenu>();
            foreach (var item in menuList)
            {
                Console.WriteLine(item);
            }
        }

        private void InputMenu(AppMenu MenuChoice)
        {
            switch (MenuChoice)
            {
                case AppMenu.viewmenu:
                    ViewMenu();
                    break;
                case AppMenu.viewcart:
                    ViewCart();
                    break;
                case AppMenu.additem:
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

        private void ViewMenu()
        {
            IEnumerable<StoreMenu> Menus = Enum.GetValues(typeof(StoreMenu)).Cast<StoreMenu>();
            foreach (StoreMenu Menu in Menus)
            {
                Console.WriteLine($"[{(int)Menu}]. {Menu}");
            }
        }

        private void ViewCart()
        {
            foreach (IProduct item in Cart)
            {
                Console.WriteLine($"{item}");
            }
        }

        public void AddItem()
        {
            //    // DisplayStoreItems();

            //    var input = Console.ReadLine();
            //    int quantity = int.Parse(Console.ReadLine());
            //    if (Cart.Exists(item => item.Name == input))
            //    {
            //        if (Store.TryGetValue(input, out double value))
            //        {
            //            // i don't like that im using soo many iterations to find inputs, does not seem very effective,
            //            // maybe like a O(n*2).. and i do mean n*2 since it seems like im doing a 
            //            // couple loops to do this. 
            //            int location = Cart.FindIndex(item => item.Name == input);
            //            double newVal = value * quantity;
            //            Cart[location].Quantity += quantity;
            //            Cart[location].Price += newVal;
            //        }
            //    }
            //    else if (Store.TryGetValue(input, out double value))
            //    {
            //        Cart.Add(new StoreItem(input, value * quantity, quantity));
            //    }
        }

        private void RemoveItem()
        {
            // remove item from shopping cart
        }

        private void Checkout()
        {
            Console.WriteLine($"Your subtotal due is: {Register.GetSubTotal(Cart)}");
            Console.WriteLine("How would you like to pay?");
            PaymentTypes pmtType = (PaymentTypes)Enum.Parse(typeof(PaymentTypes), Console.ReadLine());
            GetPaymentType(pmtType);
        }

        public void Quit()
        {
            Console.WriteLine("would you like to close the program? (press Y to close, N to continue)");
            ConsoleKey answer = Console.ReadKey().Key;
            if (answer == ConsoleKey.Y)
            {
                Console.WriteLine("Thank you for shopping with us, have a good day!");
                IsRunning = false;
            }
        }

        private void GetPaymentType(PaymentTypes PmtType)  //PmtType is a temporary variable
        {
            switch (PmtType)
            {

                // CASH
                case PaymentTypes.cash:
                    PaymentCash();
                    break;
                case PaymentTypes.creditCard:
                    PaymentCreditCard();
                    break;
                case PaymentTypes.check:
                    PaymentCheck();
                    break;
            }
        }

        private void PaymentCash()
        {
            Console.WriteLine("Enter total payment due: ");
            double cashAmount = double.Parse(Console.ReadLine()); //setting variable for user's cash amount
            while (cashAmount != Register.GetSubTotal(Cart))
            {
                Console.WriteLine("Amount does not match, Enter total payment due: ");
                cashAmount = double.Parse(Console.ReadLine());
            }
            UserPayment = new PmtCash(cashAmount); //making new cash object with cash class
        }

        private void PaymentCheck()
        {
            Console.WriteLine("Enter total payment due: ");
            double checkAmount = double.Parse(Console.ReadLine()); //setting variable for user's cash amount
            while (checkAmount != Register.GetSubTotal(Cart))
            {
                Console.WriteLine("Amount does not match, Enter total payment due: ");
                checkAmount = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter account number: ");
            long acctNum = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter routing number: ");
            long routNum = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter check number: ");
            int checkNum = int.Parse(Console.ReadLine());
            UserPayment = new PmtCheck(checkAmount, acctNum, routNum, checkNum); //making new cash object with cash class
        }

        private void PaymentCreditCard()
        {
            //getting information from constructor to save CC Info
            Console.WriteLine("Enter total payment due: ");
            double creditCard = double.Parse(Console.ReadLine()); //setting variable for user's cash amount
            while (creditCard != Register.GetSubTotal(Cart))
            {
                Console.WriteLine("Amount does not match, Enter total payment due: ");
                creditCard = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter credit card number: ");
            long creditCardNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter CVV code: ");
            int cvv = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter expiration date: mm/yy");
            DateTime expDate = DateTime.Parse(Console.ReadLine());
            //datetime
            Console.WriteLine("Please input your first and last name: ");
            string userName = Console.ReadLine();

            UserPayment = new PmtCreditCard(creditCard, creditCardNumber, cvv, expDate, userName); //making new cash object with cash class
        }

    }
}
