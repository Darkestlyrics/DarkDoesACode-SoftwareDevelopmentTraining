#region Info
// Development Training - ISPAssignment - Hovercraft.cs
// 
// Created by: Christopher Green
// 2019/07/10: 14:43
// 
// 
#endregion

using System;
using ISPAssignment.Enums;

namespace ISPAssignment.Classes
{
    public class Hovercraft : Abstract_Hovercraft
    {
        public Hovercraft(string make, string model, int maxSpeed, int acceleration) : base(make, model, maxSpeed, acceleration)
        {
        }

        public override void Start()
        {
            Console.WriteLine("INTERIOR CROCODILE ALLIGATOR I DRIVE A CHEVROLET MOVIE THEATER");
            base.Start();
        }
    }
}