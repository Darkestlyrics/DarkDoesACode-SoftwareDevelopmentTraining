#region Info
// Development Training - SRPAssignment - Vehicle.cs
// 
// Created by: Christopher Green
// 2019/07/09: 10:17
// 
// 
#endregion

namespace SRPAssignment.Classes
{
    public class Vehicle {
        public string Make { get; set; }
        public string Model { get; set; }
        public int MaxSpeed { get; set; }
        public int Acceleration { get; set; }
        private bool _isMoving = false;

        public void Start()
        {

        }

        public void Stop()
        {

        }

        public Vehicle(string make, string model, int maxSpeed, int acceleration)
        {
            Make = make;
            Model = model;
            MaxSpeed = maxSpeed;
            Acceleration = acceleration;
        }
    }
}
