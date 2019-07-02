using System;
using System.Collections.Generic;
using System.Linq;
using ISPExample.Classes;
using ISPExample.Interfaces;

namespace ISPExample {

    /*
     * We now have a good base to write classes that are easily extendable without disrupting the core functionality of the system
     * through interfaces and abstract classes.
     *
     * But let's think about the future, what if we need additional features to accounts that cannot be given to all accounts that
     * implement the IAccount interface
     *
     * In this example, lets implement a few new interfaces and create some new account types that will implement their own functionality, but still
     * satisfy the base conditions of an account so they can still be used, but have additional functionality.
     *
     * The Interface Segregation Principle states that an object should only implement what it needs
     */


    class Program {
        private static List<IAccountBase> _accounts = new List<IAccountBase>()
        {
            new Accountv3("1234567890", "Test Account 1", 10000),
            new Accountv3("1234567891", "Test Account 2", 1000),
            new Accountv3("1234567892", "Test Account 3", 50000),
            new Accountv3("1234567893", "Test Account 4", 10000000),
            new Accountv4(),
            new Accountv5("1234567999","new V5 Account"),
            new Accountv6(),
            new Accountv7("1234567899","Overdraft Account",10000)
        };

        private static bool _isRunning = true;
        private static bool _loggedIn = false;
        static void Main(string[] args)
        {
            string input = "";
            IAccountBase currentAccount = null;
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
                    input = Console.ReadLine();
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

        static void CheckBalance(IAccountBase acc)
        {
            Console.WriteLine($"Account Balance is : {acc.GetBalance()}");
        }

        static bool WithDrawal(IAccountBase acc)
        {
            Console.WriteLine("How much would you like to Withdraw");
            double amt = 0.00;
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

        static bool Deposit(IAccountBase acc)
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

        static IAccountBase Login(string accNum)
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

