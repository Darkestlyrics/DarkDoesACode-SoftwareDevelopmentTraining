#region Info
// Development Training - ISPAssignment - Car.cs
// 
// Created by: Christopher Green
// 2019/07/10: 14:01
// 
// 
#endregion

using ISPAssignment.Enums;

namespace ISPAssignment.Classes
{
    public class Car : Abstract_Car
    {
        public Car(string make, string model, int maxSpeed, int acceleration, int doors ,CarType type, TransmissionType transmissionType) : base(make, model, maxSpeed, acceleration, doors, type, transmissionType)
        {
        }

        public override string ToString()
        {
            return base.ToString() + "Vroom Vroom";

        }
    }
}