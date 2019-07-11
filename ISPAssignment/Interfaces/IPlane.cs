#region Info
// Development Training - ISPAssignment - IPlane.cs
// 
// Created by: Christopher Green
// 2019/07/10: 10:01
// 
// 
#endregion

using ISPAssignment.Enums;

namespace ISPAssignment.Interfaces
{
    public interface IPlane: IVehicle
    {
        int MaxAltitude { get; set; }
        PlaneType Type { get; }

        void DeployLandingGear();
        void RetractLandingGear();
        void TakeOff();
        void Land();
    }
}