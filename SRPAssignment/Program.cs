using System;
using SRPAssignment.Classes;

namespace SRPAssignment {
    class Program {
        static void Main()
        {
            Vehicle vehicle = new Vehicle("Test","vroomvroom",100,10);
            vehicle.Start();
            vehicle.Stop();
        }
    }
}
