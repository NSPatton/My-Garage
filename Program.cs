using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero()
            {
                MainColor = "Black",
                MaximumOccupancy = 4,
                BatteryKWh = 100
            };
            Tesla modelS = new Tesla()
            {
                MainColor = "Burgundy",
                MaximumOccupancy = 4,
                BatteryKWh = 100
            };
            Cessna mx410 = new Cessna()
            {
                MainColor = "Red",
                MaximumOccupancy = 2,
                FuelCapacity = 19.5
            };
            Ram classic1500 = new Ram()
            {
                MainColor = "Brown",
                MaximumOccupancy = 4,
                FuelCapacity = 26.2
            };

            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
        }
    }
}
