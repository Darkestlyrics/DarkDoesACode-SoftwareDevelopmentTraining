#region Info
// Software Dev Training - OCPExample - Account.cs
// 
// Created by: Christopher Green
// 2019/07/02: 09:09
// 
// 
#endregion

namespace OCPExample.Classes
{
    public class Accountv3
    {
            private readonly string accountNumber;

            public string AccountNumber => accountNumber;

            private readonly string accountName;

            public string AccountName => accountName;

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

    /// <summary>
    /// Here we create a new Account, an Account V4
    /// This account has everything that the Account V3 class has but it also has new functionality in that it
    /// has a new property and method.
    /// This account V4 class supports all the older functionality so the legacy code does not need to change as much
    /// </summary>
    class Accountv4 : Accountv3
    {
        protected int _pin { get; }

        public bool Login(int pin)
        {
            return (pin == _pin);
        }



    }
    }
