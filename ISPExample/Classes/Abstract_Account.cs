#region Info
// Software Dev Training - LSPExample - Abstract_Account.cs
// 
// Created by: Christopher Green
// 2019/07/02: 10:18
// 
// 
#endregion

using ISPExample.Interfaces;

namespace ISPExample.Classes {

    public abstract class Account : IAccountBase {
        public string AccountNumber { get; }
        public string AccountName { get; }
        private double _accountBalance;

        /// <summary>
        /// Get the Current Account Balance
        /// </summary>
        /// <returns>The Account Balance</returns>
        public double GetBalance()
        {
            return balance();
        }
        /// <summary>
        /// Debit an Amount from the Account
        /// </summary>
        /// <param name="amount">The Amount to Debit</param>
        ///
        ///         
        public virtual void DebitAccount(double amount)
        {
            debit(amount);
        }
        /// <summary>
        /// Credit an Amount to the Account
        /// </summary>
        /// <param name="amount">The Amount to Credit</param>
        public virtual void CreditAccount(double amount)
        {
            credit(amount);
        }


        private void credit(double a)
        {
            _accountBalance += a;
        }

        private void debit(double a)
        {

            _accountBalance -= a;
        }

        private double balance()
        {
            return _accountBalance;
        }

        protected Account(string accountNumber, string accountName)
        {
            AccountNumber = accountNumber;
            AccountName = accountName;
            _accountBalance = 0;
        }
    }
}