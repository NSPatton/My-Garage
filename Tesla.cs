using System;

namespace Garage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public override void Drive()
        {
            // method definition omitted
            Console.WriteLine($"This {MainColor} Tesla blazes by you!");
            base.Drive();
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