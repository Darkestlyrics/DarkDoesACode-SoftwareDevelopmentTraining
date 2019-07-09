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
        private bool _isMoving { get; set; }
        public void Start()
        {
            if (!_isMoving)
            {
                Console.WriteLine($"{ToString()} is moving");
                _isMoving = true;
            }
        }


        public void Stop()
        {
            if (_isMoving)
            {
                Console.WriteLine($"{ToString()} is not moving");
                _isMoving = false;
            }
        }

        public string ToString()
        {
            return $"Vehicle: {Make} - {Model}";
        }
    }
}