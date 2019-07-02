#region Info
// Software Dev Training - LSPExample - Abstract_Account.cs
// 
// Created by: Christopher Green
// 2019/07/02: 10:18
// 
// 
#endregion

using LSPExample.Interfaces;

namespace LSPExample.Classes {
    /*
     * An abstract class is similar to an interface in that it provides a template for classes to derive from
     * However there are a number of differences:
     *
     * -Abstract classes support fields
     * -Abstract classes allow you to define the base behavior of methods
     *      +This means you can stipulate what a method does for all derived classes (don't worry, they can override this)
     *
     *
     * Something else to note, the Methods in the Abstract class have been marked as Virtual Methods, this means that they are not
     * a solid implementation of a method, meaning they can be redefined by derived classes
     *
     * **NOTE** Not all methods should be marked as virtual, if a class has concrete functionality that should not be changed, it should
     * not be marked as Virtual, these have been done for teaching purposes
     */
    public abstract class Account : IAccount {
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