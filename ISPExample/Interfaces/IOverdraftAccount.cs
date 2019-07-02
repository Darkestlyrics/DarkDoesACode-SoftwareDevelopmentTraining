#region Info
// Software Dev Training - ISPExample - IOverdraftAccount.cs
// 
// Created by: Christopher Green
// 2019/07/02: 12:03
// 
// 
#endregion

using System.Dynamic;

namespace ISPExample.Interfaces
{

    /*
     * We Implement the IAccountBase here as any Overdraft Account will still be an Account, but not all accounts will be overdraft accounts
     */
    public interface IOverdraftAccount : IAccountBase
    {
         double OverDraftLimit { get; }
    }
}