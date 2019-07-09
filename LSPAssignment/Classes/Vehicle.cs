using System;
using System.Collections.Generic;
using System.Text;
using LSPAssignment.Intefaces;

namespace LSPAssignment.Classes {
    public class Vehicle :IVehicle {
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

