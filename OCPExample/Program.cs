using System;
using System.Collections.Generic;
using System.Linq;
using OCPExample.Classes;

namespace OCPExample {
    class Program {
        /*
         * Using the example class we created in the Single Responsibility example
         * lets say we needed to implement new functionality into the existing account class
         * we could just change the code, however that would violate the Open/Closed principle
         *
         * In this example, lets say the account class is currently used in an ATM system
         *
         * They would like to extend the functionality of the existing Accountv3 class, however they need to keep that code the same
         * so their legacy ATM solution is supported
         */


        //////////////////////////// LEGACY CODE  /////////////////////////////////////////////////

        private static readonly List<Accountv3> _accounts = new List<Accountv3>()
        {
            new Accountv3("1234567890", "Test Account 1", 10000),
            new Accountv3("1234567891", "Test Account 2", 1000),
            new Accountv3("1234567892", "Test Account 3", 50000),
            new Accountv3("1234567893", "Test Account 4", 10000000),
            new Accountv4()
        };

        private static readonly bool _isRunning = true;
        private static bool _loggedIn = false;
        static void Main()
        {
            while (_isRunning)
            {
                Console.WriteLine("Welcome to Test Bank's new ATM Service, Please enter your account details");
                string temp = Console.ReadLine();
                var currentAccount = Login(temp);
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

        static void CheckBalance(Accountv3 acc)
        {
            Console.WriteLine($"Account Balance is : {acc.GetBalance()}");
        }

        static bool WithDrawal(Accountv3 acc)
        {
            Console.WriteLine("How much would you like to Withdraw");
            try
            {
                double amt;
                double.TryParse(Console.ReadLine(), out amt);
                acc.DebitAccount(amt);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        static bool Deposit(Accountv3 acc)
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

        static Accountv3 Login(string accNum)
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
