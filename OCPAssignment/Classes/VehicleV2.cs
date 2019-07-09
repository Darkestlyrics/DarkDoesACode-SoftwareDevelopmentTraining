#region Info
// Development Training - OCPAssignment - VehicleV2.cs
// 
// Created by: Christopher Green
// 2019/07/09: 10:50
// 
// 
#endregion

namespace OCPAssignment.Classes
{
    public class VehicleV2 : Vehicle {
        public int CurrentSpeed { get; protected set; } = 0;


        public VehicleV2(string make, string model, int maxSpeed, int acceleration) : base(make, model, maxSpeed, acceleration)
        {
        }

        public void Accelerate()
        {
            if (CurrentSpeed <MaxSpeed)
            {
                CurrentSpeed += Acceleration;
            }
        }
    }
}