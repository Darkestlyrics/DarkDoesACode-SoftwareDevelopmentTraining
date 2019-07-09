#region Info
// Software Dev Training - SRPExample - Account.cs
// 
// Created by: Christopher Green
// 2019/07/02: 08:27
// 
// 
#endregion

namespace SRPExample.Classes {
    /// <summary>
    /// Simple Account Class
    /// only has properties
    /// </summary>
    public class Accountv1 {
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public double AccountBalance { get; set; }
    }

    /// <summary>
    /// Account Class version 2
    /// has properties and a constructor
    /// </summary>
    public class Accountv2 {
        private readonly string accountNumber;

        public string AccountNumber => accountNumber;

        private readonly string accountName;

        public string AccountName => accountName;

        private readonly double accountBalance;

        public double AccountBalance => accountBalance;

        public Accountv2()
        {

        }

        public Accountv2(string accountNumber, string accountName, double accountBalance)
        {
            this.accountNumber = accountNumber;
            this.accountName = accountName;
            this.accountBalance = accountBalance;
        }
    }

    /// <summary>
    /// Account class version 3
    /// has properties and a constructor
    /// manages it's own properties
    /// </summary>
    public class Accountv3 {
        private readonly string accountNumber;

        public string AccountNumber => accountNumber;

        private readonly string accountName;

        public string AccountName => accountName;

        /// <summary>
        /// Has been changed to private as it does not need to be directly called at any stage.
        /// The balance method has been implemented to show this if the criteria are met
        /// </summary>
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
            //We could add additional security here, i.e. a pin system
            return Balance();
        }

        public void DebitAccount(double amount)
        {
            //We could add additional security here, i.e. a pin system
            Debit(amount);
        }

        public void CreditAccount(double amount)
        {
            //We could add additional security here, i.e. a pin system
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
}