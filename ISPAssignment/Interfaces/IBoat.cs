#region Info
// Development Training - ISPAssignment - IBoat.cs
// 
// Created by: Christopher Green
// 2019/07/10: 10:01
// 
// 
#endregion

using System.Runtime.CompilerServices;
using ISPAssignment.Enums;

namespace ISPAssignment.Interfaces
{
    public interface IBoat : IVehicle { 
        BoatType Type { get; }

        void Undock();
        void Dock();

    }
}