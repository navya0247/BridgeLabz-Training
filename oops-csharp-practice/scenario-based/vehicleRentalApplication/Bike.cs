using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased.vehicleRentalApplication
{
    internal class Bike : Vehicle, IRentable
    {
        public Bike(int vehicleId, string vehicleName, double ratePerDay):base(vehicleId, vehicleName, ratePerDay)
            {
        }

        public double CalculateRent(int days)
        {
            return ratePerDay * days;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Vehicle Type: Bike");

        }

    }
}
