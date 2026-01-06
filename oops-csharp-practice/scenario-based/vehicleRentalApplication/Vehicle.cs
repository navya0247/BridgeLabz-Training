using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased.vehicleRentalApplication
{
    internal class Vehicle
    {
        protected int vehicleId;
        protected string vehicleName;
        protected double ratePerDay;

        public Vehicle(int vehicleId,string vehicleName,double ratePerDay)
        {
            this.vehicleId = vehicleId;
            this.vehicleName = vehicleName;
            this.ratePerDay = ratePerDay;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Vehicle ID: " + vehicleId);
            Console.WriteLine("Vehicle Name: " + vehicleName);
            Console.WriteLine("Rate/Day: " + ratePerDay);
        }
    }
}
