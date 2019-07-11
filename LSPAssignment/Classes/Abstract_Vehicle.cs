#region Info
// Development Training - LSPAssignment - Abstract_Vehicle.cs
// 
// Created by: Christopher Green
// 2019/07/09: 11:15
// 
// 
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using LSPAssignment.Intefaces;

namespace LSPAssignment.Classes
{
    public class Abstract_Vehicle : IVehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int MaxSpeed { get; set; }
        public int Acceleration { get; set; }
        private bool _isOn { get; set; }

        public Abstract_Vehicle(string make, string model, int maxSpeed, int acceleration)
        {
            Make = make;
            Model = model;
            MaxSpeed = maxSpeed;
            Acceleration = acceleration;
            
        }
        public virtual void Start()
        {
            if (_isOn)
            {
                Console.WriteLine($"{ToString()} is already on");
            }
            else
            {
                Console.WriteLine($"{ToString()} is on");
                _isOn = true;
            }
        }


        public virtual void Stop()
        {
            if (!_isOn)
            {
                Console.WriteLine($"{ToString()} is already off");
            }
            else
            {
                Console.WriteLine($"{ToString()} is off");
                _isOn = false;
            }
        }

        public virtual string ToString()
        {
            return $"Vehicle: {Make} - {Model}";
        }
    }
}