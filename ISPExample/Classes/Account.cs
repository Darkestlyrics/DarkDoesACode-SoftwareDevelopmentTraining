#region Info
// Software Dev Training - LSPExample - Account.cs
// 
// Created by: Christopher Green
// 2019/07/02: 09:55
// 
// 
#endregion

using ISPExample.Interfaces;

namespace ISPExample.Classes
{
 
    public class Accountv3 : IAccountBase
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

    class Accountv4 : IAccountBase
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

        public Accountv5(string accountNumber, string accountName) : base(accountNumber, accountName)
        {
        }


        public override void DebitAccount(double amount)
        {
            if (GetBalance() > amount)
            {
               base.DebitAccount(amount);
            }
        }
    }

    class Accountv6 : IOverdraftAccount
    {
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

        public double OverDraftLimit { get; }
    }

    class Accountv7 : OverdraftAccount
    {
        public Accountv7(string accountNumber, string accountName, double overdraftLimit) : base(accountNumber, accountName, overdraftLimit)
        {
        }
    }
}