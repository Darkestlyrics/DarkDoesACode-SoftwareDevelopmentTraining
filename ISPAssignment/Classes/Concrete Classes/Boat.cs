#region Info
// Development Training - ISPAssignment - Boat.cs
// 
// Created by: Christopher Green
// 2019/07/10: 14:02
// 
// 
#endregion

using ISPAssignment.Enums;

namespace ISPAssignment.Classes
{
    public class Boat : Abstract_Boat
    {
        public Boat(string make, string model, int maxSpeed, int acceleration, BoatType type) : base(make, model, maxSpeed, acceleration, type)
        {
        }
    }
}