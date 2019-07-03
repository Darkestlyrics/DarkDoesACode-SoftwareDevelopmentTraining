#region Info
// Software Dev Training - LSPExample - Account.cs
// 
// Created by: Christopher Green
// 2019/07/02: 09:55
// 
// 
#endregion

using LSPExample.Interfaces;

namespace LSPExample.Classes
{
    /*
     * By stating that the Account V3 and Account V4 classes Implement the IAccount Interface, we are stating
     * that both of them have the properties and functionality and can be called the same way, but may perform the
     * method differently
     */
    public class Accountv3 : IAccount
    {
        private readonly string accountNumber;

        public string AccountNumber => accountNumber;

        private readonly string accountName;

        public string AccountName => accountName;

        public double AccountBalance { get; }

        private double accountBalance;

        public Accountv3()
        {

        }

        public Accountv3(string accountNumber, string accountName, double accountBalance)
        {
            this.accountNumber = accountNumber;
            this.accountName = accountName;
            this.accountBalance = accountBalance;
        }

        public double GetBalance()
        {
            return Balance();
        }

        public void DebitAccount(double amount)
        {
            Debit(amount);
        }

        public void CreditAccount(double amount)
        {
            Credit(amount);
        }


        private void Debit(double amount)
        {
            accountBalance -= amount;
        }

        private void Credit(double amount)
        {
            accountBalance += amount;
        }

        private double Balance()
        {
            return accountBalance;
        }

    }

/*
 * Account V4 no longer needs to extend the Account V3 class anymore as it now implements the same base in that of the IAccount Interface
 * However it now needs to implement it's own functionality for the methods it needs to implement.
 *
 * This can be troublesome and often leads to repeated code. To solve this we can create an Abstract class
 */
    class Accountv4 : IAccount
    {
        protected int _pin { get; }

        public bool Login(int pin)
        {
            return (pin == _pin);
        }

        public string AccountNumber { get; }
        public string AccountName { get; }

        public double GetBalance()
        {
            throw new System.NotImplementedException();
        }

        public void DebitAccount(double amount)
        {
            throw new System.NotImplementedException();
        }

        public void CreditAccount(double amount)
        {
            throw new System.NotImplementedException();
        }
    }
    /*
     * Here we can see that our Account V5 implements everything that the other accounts do but does not require us to
     * redefine functionality or properties
     *
     * This allows us to also write cleaner code going forward.
     *
     * Lets add our Pin Protection functionality to this class and override some existing functionality
     */
    class Accountv5 : Account
    {

        protected int _pin { get; }

        public bool Login(int pin)
        {
            return login(pin);
        }

        private bool login(int pin)
        {
            return (pin == _pin);
        }

        /*
         * as you can see here, we have a constructor for the class, which implements our base class Constructor. This is know as
         * Constructor Chaining.
         *
         * What will happen here is that the base constructor will run first, as it is the base of the derived class. we can then do additional
         * work that will exist exclusively within this derivation of the base class.
         *
         * This means that each derivation of the base class can have it's own logic in it's constructor (to populate additional properties or fields)
         * but that each of them will follow the base constructor first
         */
        public Accountv5(string accountNumber, string accountName) : base(accountNumber, accountName)
        {
        }


        /*
         *Lets override the CreditAccount Method now to have it function slightly different
         * **NOTE** you can only override Virtual Methods
         *
         *
         * See that it calls the base.DebitAccount() method.
         * what this is doing is calling the base class' DebitAccount() methods and leveraging off that functionality.
         * for this example we're going to override it to check if the account is funded sufficiently before we Debit it
         * **NOTE** we cannot use the private methods implemented in the base class.
         */

        public override void DebitAccount(double amount)
        {
            if (GetBalance() > amount)
            {
               base.DebitAccount(amount);
            }
        }
    }
}