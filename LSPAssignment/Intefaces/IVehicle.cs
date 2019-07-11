#region Info
// Development Training - LSPAssignment - IVehicle.cs
// 
// Created by: Christopher Green
// 2019/07/09: 10:33
// 
// 
#endregion

namespace LSPAssignment.Intefaces
{
    public interface IVehicle
    {
         string Make { get; set; }
         string Model { get; set; }
         int MaxSpeed { get; set; }
         int Acceleration { get; set; }
         void Start();
         void Stop();

    }
}