using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased.vehicleRentalApplication
{
    internal class VehicleRentalApplication
    {
        public static void Main(string[] args)
        {
            Customer customer = new Customer(1, "Navya Yadav");
            customer.DisplayCustomer();

            Console.WriteLine();

            Vehicle vehicle;
            IRentable rentable;

            vehicle = new Car(101, "Porsche", 10000);
            rentable = (IRentable)vehicle;

            vehicle.DisplayInfo();
            Console.WriteLine("Total Rent :" + rentable.CalculateRent(3));

            Console.WriteLine();

            vehicle = new Bike(102, "Bullet", 800);
            rentable = (IRentable)vehicle;

            vehicle.DisplayInfo();
            Console.WriteLine("Total Rent :" + rentable.CalculateRent(3));

            Console.WriteLine();

            vehicle = new Truck(103, "Tata Truck", 4000);
            rentable = (IRentable)vehicle;

            vehicle.DisplayInfo();

            Console.WriteLine("Total Rent :" + rentable.CalculateRent(3));



        }

    }
}
