#region Info
// Development Training - ISPAssignment - Vehicle.cs
// 
// Created by: Christopher Green
// 2019/07/10: 10:00
// 
// 
#endregion

namespace ISPAssignment.Classes
{
    public class Vehicle : Abstract_Vehicle
    {
        public Vehicle(string make, string model, int maxSpeed, int acceleration) : base(make, model, maxSpeed, acceleration)
        {
        }
    }
}