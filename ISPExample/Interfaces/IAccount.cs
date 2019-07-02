#region Info
// Software Dev Training - LSPExample - IAccount.cs
// 
// Created by: Christopher Green
// 2019/07/02: 10:03
// 
// 
#endregion

namespace ISPExample.Interfaces
{
    /*
     * Here we can see our IAccount interface, let's split this up into a couple of logical interfaces
     */
    public interface IAccountBase
    {
        /// <summary>
        /// The Account Number
        /// </summary>
        string AccountNumber { get; }

        /// <summary>
        /// The Name of the Account
        /// </summary>
        string AccountName { get; }
 
        double GetBalance();

        void DebitAccount(double amount);

        void CreditAccount(double amount);
    }


}