#region Info
// Development Training - ISPAssignment - Boat.cs
// 
// Created by: Christopher Green
// 2019/07/10: 13:22
// 
// 
#endregion

using ISPAssignment.Enums;
using ISPAssignment.Interfaces;

namespace ISPAssignment.Classes
{
    public abstract class Abstract_Boat : Abstract_Vehicle, IBoat
    {
        protected Abstract_Boat(string make, string model, int maxSpeed, int acceleration, BoatType type) : base(make, model, maxSpeed, acceleration)
        {
            Type = type;
        } 

        public BoatType Type { get; set; }
        public void Undock()
        {
            
        }

        public void Dock()
        {
            throw new System.NotImplementedException();
        }
    }
}