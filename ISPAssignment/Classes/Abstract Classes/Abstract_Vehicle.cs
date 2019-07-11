#region Info
// Development Training - ISPAssignment - Abstract_Vehicle.cs
// 
// Created by: Christopher Green
// 2019/07/10: 10:00
// 
// 
#endregion

using System;
using ISPAssignment.Interfaces;

namespace ISPAssignment.Classes
{
    public class Abstract_Vehicle : IVehicle {
        public string Make { get; set; }
        public string Model { get; set; }
        public int MaxSpeed { get; set; }
        public int Acceleration { get; set; }
        private bool _isOn { get; set; }

        protected Abstract_Vehicle(string make, string model, int maxSpeed, int acceleration )
        {
            Make = make;
            Model = model;
            MaxSpeed = maxSpeed;
            Acceleration = acceleration;
        }
        public virtual void Start()
        {
            if (!_isOn)
            {
                Console.WriteLine($"{ToString()} is moving");
                _isOn = true;
            }
        }


        public virtual void Stop()
        {
            if (_isOn)
            {
                Console.WriteLine($"{ToString()} is not moving");
                _isOn = false;
            }
        }

        public virtual string ToString()
        {
            return $"Vehicle:Type {GetType().Name}  {Make} - {Model}";
        }
    }
}