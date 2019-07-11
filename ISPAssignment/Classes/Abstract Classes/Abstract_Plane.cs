#region Info
// Development Training - ISPAssignment - Plane.cs
// 
// Created by: Christopher Green
// 2019/07/10: 13:23
// 
// 
#endregion

using ISPAssignment.Enums;
using ISPAssignment.Interfaces;

namespace ISPAssignment.Classes
{
    public abstract class Abstract_Plane : Abstract_Vehicle, IPlane
    {
        public int MaxAltitude { get; set; }
        public PlaneType Type { get; set; }
        public void DeployLandingGear()
        {
            
        }

        public void RetractLandingGear()
        {
           
        }

        public void TakeOff()
        {
  
        }

        public void Land()
        {
 
        }

        protected Abstract_Plane(string make, string model, int maxSpeed, int acceleration, int maxAltitude, PlaneType type) : base(make, model, maxSpeed, acceleration)
        {
            MaxAltitude = maxAltitude;
            Type = type;
        }
    }
}