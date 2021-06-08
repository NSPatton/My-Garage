using System;

namespace Garage
{
    public class Ram : Vehicle  // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.Write($"The {MainColor} Ram guzzles its way by!");
            Console.WriteLine("RRRRRUUUUMMMBLE!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Ram Chugs to the {direction}!");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Ram clumsily comes to a stop.");
        }
    }
}