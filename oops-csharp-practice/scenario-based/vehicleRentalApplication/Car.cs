using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased.vehicleRentalApplication
{
    internal class Car : Vehicle, IRentable
    {
        public Car(int vehicleId, string vehicleName, double ratePerDay) : base(vehicleId, vehicleName, ratePerDay)
        {

        }

        public double CalculateRent(int days)
        {
            return (ratePerDay * days) + 500;
        }

        public override void DisplayInfo()
        {

            base.DisplayInfo();
            Console.WriteLine("Vehicle Type : Car");
        }

    }
}
   
