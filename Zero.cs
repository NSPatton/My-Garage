using System;

namespace Garage
{
    public class Zero : Vehicle
    {
        public double BatteryKWh { get; set; }

        public override void Drive()
        {
            // method definition omitted
            Console.Write($"This {MainColor} Zero Speeds Past! ");
            base.Drive();
        }
    }
}