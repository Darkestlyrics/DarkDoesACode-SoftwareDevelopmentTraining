#region Info
// Development Training - ISPAssignment - IVehicle.cs
// 
// Created by: Christopher Green
// 2019/07/10: 10:00
// 
// 
#endregion

namespace ISPAssignment.Interfaces
{
    public interface IVehicle {
        string Make { get; set; }
        string Model { get; set; }
        int MaxSpeed { get; set; }
        int Acceleration { get; set; }
        void Start();
        void Stop();

    }
}