#region Info
// Development Training - ISPAssignment - Abstract_Hovercraft.cs
// 
// Created by: Christopher Green
// 2019/07/10: 14:55
// 
// 
#endregion

using System;
using ISPAssignment.Enums;
using ISPAssignment.Interfaces;

namespace ISPAssignment.Classes
{
    public class Abstract_Hovercraft : Abstract_Vehicle, IBoat, ICar
    {
        private BoatType _boatType = BoatType.Other;
        private CarType _carType = CarType.Other;
        private bool _infalted;
        public string Make { get; set; }
        public string Model { get; set; }
        public int MaxSpeed { get; set; }
        public int Acceleration { get; set; }


        public override void Start()
        {
            Inflate();
            base.Start();
        }

        public override void Stop()
        {
            Deflate();
            base.Stop();
        }

        private void Inflate()
        {
            if (_infalted)
            {
                Console.WriteLine("Already Inflated");
            }
            else
            {
                Console.WriteLine("Inflating");
                _infalted = true;
            }
        }

        private void Deflate()
        {
            if (!_infalted)
            {
                Console.WriteLine("Already Deflated");
            }
            else
            {
                Console.WriteLine("Deflating");
                _infalted = false;
            }
        }

        BoatType IBoat.Type => _boatType;

        CarType ICar.Type => _carType;
        public TransmissionType TransmissionType { get; set; }

        public void Undock()
        {
            Console.WriteLine("lol ok");
        }

        public void Dock()
        {
            Console.WriteLine("dock this you casual");
        }

        protected Abstract_Hovercraft(string make, string model, int maxSpeed, int acceleration) : base(make, model, maxSpeed, acceleration)
        {
        }
    }
}