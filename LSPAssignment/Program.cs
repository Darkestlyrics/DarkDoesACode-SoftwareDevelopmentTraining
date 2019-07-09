using System;
using LSPAssignment.Classes;
using LSPAssignment.Intefaces;

namespace LSPAssignment {
    class Program {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle("Vehicle","V1",100,10);
            Move(vehicle);
            VehicleV2 vehicleV2 = new VehicleV2("Vehicle", "V2", 120, 10);
            Move(vehicleV2);
        }

        static void Move(IVehicle vehicle)
        {
            vehicle.Start();
            vehicle.Stop();
        }


    }
}
