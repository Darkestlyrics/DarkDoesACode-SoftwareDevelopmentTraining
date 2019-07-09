using System;
using System.Collections.Generic;
using System.Text;
using LSPAssignment.Intefaces;

namespace LSPAssignment.Classes {
    public class VehicleV2 : IVehicle {
        public int CurrentSpeed { get; protected set; } = 0;


        public VehicleV2(string make, string model, int maxSpeed, int acceleration)
        {
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int MaxSpeed { get; set; }
        public int Acceleration { get; set; }
        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
