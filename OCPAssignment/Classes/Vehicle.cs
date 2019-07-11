#region Info
// Development Training - OCPAssignment - Vehicle.cs
// 
// Created by: Christopher Green
// 2019/07/09: 10:21
// 
// 
#endregion

namespace OCPAssignment.Classes {

    public class Vehicle {
        public string Make { get; set; }
        public string Model { get; set; }
        public int MaxSpeed { get; set; }
        public int Acceleration { get; set; }
        private bool _isOn = false;


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