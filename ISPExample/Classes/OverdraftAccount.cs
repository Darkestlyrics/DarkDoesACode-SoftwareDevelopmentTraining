#region Info
// Software Dev Training - ISPExample - OverdraftAccount.cs
// 
// Created by: Christopher Green
// 2019/07/02: 12:07
// 
// 
#endregion

using ISPExample.Interfaces;

namespace ISPExample.Classes
{
    public class OverdraftAccount : Account,IOverdraftAccount
    {

        private double _accountBalance;
        public double OverDraftLimit { get; protected set; }

        /*
         * Here we've overridden the base class' virtual method with our own implementation of it to support the overdraft
         */

        public override void DebitAccount(double amount)
        {
            if ((GetBalance() + OverDraftLimit) > amount)
            {
                base.DebitAccount(amount);
            }
        }



 

        public OverdraftAccount(string accountNumber, string accountName, double overdraftLimit) : base(accountNumber, accountName)
        {
            OverDraftLimit = overdraftLimit;
        }

    }
}