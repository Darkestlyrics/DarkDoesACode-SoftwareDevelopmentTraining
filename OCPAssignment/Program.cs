using System;
using OCPAssignment.Classes;

namespace OCPAssignment {
    class Program {
        static void Main(string[] args)
        {
            VehicleV2 vehicle = new VehicleV2("Test", "vroomvroom", 100, 10);
            vehicle.Start();
            vehicle.Stop();
        }
    }
}
