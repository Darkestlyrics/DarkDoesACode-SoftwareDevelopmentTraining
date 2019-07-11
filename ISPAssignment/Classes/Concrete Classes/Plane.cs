#region Info
// Development Training - ISPAssignment - Plane.cs
// 
// Created by: Christopher Green
// 2019/07/10: 14:02
// 
// 
#endregion

using ISPAssignment.Enums;

namespace ISPAssignment.Classes
{
    public class Plane : Abstract_Plane
    {
        public Plane(string make, string model, int maxSpeed, int acceleration, int maxAltitude, PlaneType type) : base(make, model, maxSpeed, acceleration, maxAltitude, type)
        {
        }
    }
}