using System;
using LSPAssignment.Classes;
using LSPAssignment.Intefaces;

namespace LSPAssignment {
    class Program {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle("Vehicle","V1",100,10);
            StartVehicle(vehicle);
            StopVehicle(vehicle);
            VehicleV2 vehicleV2 = new VehicleV2("Vehicle", "V2", 120, 10);
            StartVehicle(vehicleV2);
            StopVehicle(vehicleV2);

        }

        static void StartVehicle(IVehicle vehicle)
        {
            vehicle.Start();

        }
        static void StopVehicle(IVehicle vehicle)
        {
            vehicle.Stop();
        }

    }
}
