using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased.vehicleRentalApplication
{
    internal class Truck:Vehicle,IRentable
    {
        public Truck(int vehicleId,string vehicleName,double ratePerDay) : base(vehicleId, vehicleName, ratePerDay)
        {

        }
        public double CalculateRent(int days)
        {
            return (ratePerDay * days) + 1000; //extra charge
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Vehicle Type : Truck");
        }
    }
}
