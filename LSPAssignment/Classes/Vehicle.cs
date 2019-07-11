using System;
using System.Collections.Generic;
using System.Text;
using LSPAssignment.Intefaces;

namespace LSPAssignment.Classes {
    public class Vehicle : Abstract_Vehicle {
        public Vehicle(string make, string model, int maxSpeed, int acceleration) : base(make, model, maxSpeed, acceleration)
        {
        }
    }


}

