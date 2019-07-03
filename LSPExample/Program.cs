using System;
using System.Collections.Generic;
using System.Linq;
using LSPExample.Classes;
using LSPExample.Interfaces;

namespace LSPExample {
    class Program {
        /*
         * As you may have noticed in the Open/Closed example, we created the Account V4 class,
         * however the legacy code cannot just make use of it. For them to do that they would
         * need to upgrade all Account V3 accounts to Account V4 accounts which could take ages.
         * So how do we accomplish this, as we would like to start opening and using Accounts that
         * are Account V4.
         *
         * The Liskov Substitution stats that if a class A is of a SUBTYPE of class B it should be able to be
         * used without disruption.
         *
         * However there is another issue, what if we need to implement an Account V5 that needs to check the balance of the account
         * before it can make a withdrawal? We can extend the class and add functionality, but we cannot just change the way it works each time, or can we?
         *
         * Let's create an interface for the accounts so we can establish a template for the accounts
         *
         * After that we can create an Abstract Class to define the base functionality of the accounts
         * 
         */



        //////////////////////////// LEGACY CODE  /////////////////////////////////////////////////


            /*
             * By changing the concrete Account V3 to IAccount, we can now make use of any class that derives from IAccount without changing
             * the legacy code
             */

        private static readonly List<IAccount> _accounts = new List<IAccount>()
        {
            new Accountv3("1234567890", "Test Account 1", 10000),
            new Accountv3("1234567891", "Test Account 2", 1000),
            new Accountv3("1234567892", "Test Account 3", 50000),
            new Accountv3("1234567893", "Test Account 4", 10000000),
            new Accountv4(),
            new Accountv5("1234567999","new V5 Account")
        };

        private static readonly bool _isRunning = true;
        private static bool _loggedIn = false;
        static void Main(string[] args)
        {
            IAccount currentAccount = null;
            while (_isRunning)
            {
                Console.WriteLine("Welcome to Test Bank's new ATM Service, Please enter your account details");
                string temp = Console.ReadLine();
                currentAccount = Login(temp);
                if (currentAccount != null)
                    _loggedIn = true;
                else
                    Console.WriteLine($"Account with account number {temp} could note be found");
                while (_loggedIn)
                {
                    DisplayOptions();
                    var input = Console.ReadLine();
                    switch (input)
                    {
                        case "1":
                            CheckBalance(currentAccount);
                            break;
                        case "2":
                            WithDrawal(currentAccount);
                            break;
                        case "3":
                            Deposit(currentAccount);
                            break;
                        case "4":
                            logout();
                            break;

                        default:
                            Console.WriteLine("Invalid Option Selected, Please try again");
                            DisplayOptions();
                            break;

                    }
                }
            }
        }

        static void CheckBalance(IAccount acc)
        {
            Console.WriteLine($"Account Balance is : {acc.GetBalance()}");
        }

        static bool WithDrawal(IAccount acc)
        {
            Console.WriteLine("How much would you like to Withdraw");
            double amt;
            try
            {
                double.TryParse(Console.ReadLine(), out amt);
                acc.DebitAccount(amt);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        static bool Deposit(IAccount acc)
        {
            Console.WriteLine("How much would you like to Deposit");
            double amt = 0.00;
            try
            {
                double.TryParse(Console.ReadLine(), out amt);
                acc.CreditAccount(amt);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        static void logout()
        {
            _loggedIn = false;
        }

        static IAccount Login(string accNum)
        {
            return _accounts.FirstOrDefault(o => o.AccountNumber == accNum);
        }

        static void Greet(Accountv3 acc)
        {
            Console.WriteLine($"Hi {acc.AccountName}");
        }
        static void DisplayOptions()
        {
            Console.WriteLine("Welcome to Test Bank's new ATM Service, what would you like to do? " +
                              "\n 1) Check your balance " +
                              "\n 2) Make a Withdrawal " +
                              "\n 3) Make a Deposit " +
                              "\n 4) logout");
        }


    }
}

