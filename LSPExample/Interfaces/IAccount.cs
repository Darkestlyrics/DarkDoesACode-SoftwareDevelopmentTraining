#region Info
// Software Dev Training - LSPExample - IAccount.cs
// 
// Created by: Christopher Green
// 2019/07/02: 10:03
// 
// 
#endregion

namespace LSPExample.Interfaces
{

    /*
     * An interface is like a template of an object
     * Any and all objects that implement this object will have the same base properties and methods,
     * however they may make use of these differently
     *
     * **NOTE** you cannot have fields in an interface, so think carefully
     * as you may see we have not put the AccountBalance as a property in the interface. If we did this
     * then all subsequent classes implementing the interface would need to expose this property
     */
    public interface IAccount
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