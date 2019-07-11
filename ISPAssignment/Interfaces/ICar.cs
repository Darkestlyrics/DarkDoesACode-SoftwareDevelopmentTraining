#region Info
// Development Training - ISPAssignment - ICar.cs
// 
// Created by: Christopher Green
// 2019/07/10: 10:01
// 
// 
#endregion

using ISPAssignment.Enums;

namespace ISPAssignment.Interfaces
{
    public interface ICar :IVehicle
    {
         CarType Type { get; }
         TransmissionType TransmissionType { get; set; }



    }
}