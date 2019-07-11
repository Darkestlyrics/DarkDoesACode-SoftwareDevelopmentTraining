using System;
using ISPAssignment.Classes;
using ISPAssignment.Enums;
using ISPAssignment.Interfaces;

namespace ISPAssignment {
    class Program {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle("Vehicle", "V1", 100, 10);
            StartVehicle(vehicle);
            StopVehicle(vehicle);
            VehicleV2 vehicleV2 = new VehicleV2("Vehicle", "V2", 120, 10);
            StartVehicle(vehicleV2);
            StopVehicle(vehicleV2);
            Car car = new Car("Chevrolet", "Spark", 120, 5, 4,CarType.Hatchback, TransmissionType.Manual);
            car.Start();
            car.Stop();
            Plane plane = new Plane("Boeing","747",500,100,10000,PlaneType.Commerical);
            plane.Start();
            plane.Stop();
            Boat boat = new Boat("I don't know boats","Splish Splashy",120,10,BoatType.Yacht);
            boat.Start();
            boat.Stop();
            Hovercraft hovercraft = new Hovercraft("Rootem Scootem", "Dukem Nukem", 1000, 10);
            hovercraft.Start();
            hovercraft.Stop();
            Console.ReadLine();
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

