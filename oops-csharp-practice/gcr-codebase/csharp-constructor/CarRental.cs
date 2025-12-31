using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.constructors
{
    internal class CarRental
    {
            public string CustomerName;
            public string CarModel;
            public int RentalDays;

            private double CostPerDay = 1200;

            // Parameterized constructor
            public CarRental(string customerName, string carModel, int rentalDays)
            {
                CustomerName = customerName;
                CarModel = carModel;
                RentalDays = rentalDays;
            }

            public double CalculateTotalCost()
            {
                return RentalDays * CostPerDay;
            }

            public static void Main(string[] args)
            {
                CarRental rental = new CarRental("Riya", "Swift", 5);

                Console.WriteLine("Customer: " + rental.CustomerName);
                Console.WriteLine("Car: " + rental.CarModel);
                Console.WriteLine("Days: " + rental.RentalDays);
                Console.WriteLine("Total Cost: " + rental.CalculateTotalCost());
            }
        }
    }



