using System;
using System.Collections.Generic;
using System.Text;
using LSPAssignment.Intefaces;

namespace LSPAssignment.Classes {
    public class VehicleV2 : Abstract_Vehicle {
        public int CurrentSpeed { get; protected set; } = 0;


        public VehicleV2(string make, string model, int maxSpeed, int acceleration) : base(make, model, maxSpeed, acceleration)
        {
            
        }


    }
}
