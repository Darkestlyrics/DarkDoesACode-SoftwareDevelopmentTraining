#region Info
// Development Training - ISPAssignment - Car.cs
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
    public abstract class Abstract_Car : Abstract_Vehicle, ICar
    {
        protected Abstract_Car(string make, string model, int maxSpeed, int acceleration, int doors, CarType type, TransmissionType transmissionType) : base(make, model, maxSpeed, acceleration)
        {
            Doors = doors;
            Type = type;
            TransmissionType = transmissionType;
        }

        public int Doors { get; set; }
        public CarType Type { get; set; }
        public TransmissionType TransmissionType { get; set; }
    }
}