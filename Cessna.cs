using System;

namespace Garage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna takes flight!");
            Console.WriteLine("Zoooooom!");
        }

        public override void Turn(string direction)
        {
            base.Turn(direction);
        }

        public override void Stop()
        {
            base.Stop();
        }
    }
}