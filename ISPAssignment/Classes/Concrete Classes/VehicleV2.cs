#region Info
// Development Training - ISPAssignment - VehicleV2.cs
// 
// Created by: Christopher Green
// 2019/07/10: 10:00
// 
// 
#endregion

namespace ISPAssignment.Classes
{
    public class VehicleV2 : Abstract_Vehicle {
        public int CurrentSpeed { get; protected set; } = 0;


        public VehicleV2(string make, string model, int maxSpeed, int acceleration) : base(make, model, maxSpeed, acceleration)
        {
        }


    }
}
