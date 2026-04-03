using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.encapsulation
{ 
        // interface for insurance related methods
        interface IInsurable
        {
            double CalculateInsurance();
            string GetInsuranceDetails();
        }

        // abstract base class
        abstract class Vehicle
        {
            // encapsulation using private fields
            private string vehicleNumber;
            private string type;
            private double rentalRate;

            // getter and setter
            public string VehicleNumber
            {
                get { return vehicleNumber; }
                set { vehicleNumber = value; }
            }

            public string Type
            {
                get { return type; }
                set { type = value; }
            }

            public double RentalRate
            {
                get { return rentalRate; }
                set { rentalRate = value; }
            }

            // abstract method
            public abstract double CalculateRentalCost(int days);

            // common display method
            public void DisplayVehicle()
            {
                Console.WriteLine("Vehicle Number : " + VehicleNumber);
                Console.WriteLine("Vehicle Type   : " + Type);
            }
        }

        // car class
        class Car : Vehicle, IInsurable
        {
         
            private string insurancePolicyNumber;

            public void SetPolicyNumber(string policyNo)
            {
                insurancePolicyNumber = policyNo;
            }

            public override double CalculateRentalCost(int days)
            {
                return RentalRate * days;
            }

            public double CalculateInsurance()
            {
                return 500;
            }

            public string GetInsuranceDetails()
            {
                return "Car insurance policy : " + insurancePolicyNumber;
            }
        }

        // bike class
        class Bike : Vehicle, IInsurable
        {
            private string insurancePolicyNumber;

            public void SetPolicyNumber(string policyNo)
            {
                insurancePolicyNumber = policyNo;
            }

            public override double CalculateRentalCost(int days)
            {
                return (RentalRate * days) - 100;
            }

            public double CalculateInsurance()
            {
                return 200;
            }

            public string GetInsuranceDetails()
            {
                return "Bike insurance policy : " + insurancePolicyNumber;
            }
        }

        // truck class
        class Truck : Vehicle, IInsurable
        {
            private string insurancePolicyNumber;

            public void SetPolicyNumber(string policyNo)
            {
                insurancePolicyNumber = policyNo;
            }

            public override double CalculateRentalCost(int days)
            {
                return (RentalRate * days) + 1000;
            }

            public double CalculateInsurance()
            {
                return 1200;
            }

            public string GetInsuranceDetails()
            {
                return "Truck insurance policy : " + insurancePolicyNumber;
            }
        }

        // main class
        internal class VehicleRentalSystem
        {
            public static void Main(string[] args)
            {
                Console.Write("Enter number of vehicles: ");
                int count = int.Parse(Console.ReadLine());

                // array of vehicle reference for polymorphism
                Vehicle[] vehicles = new Vehicle[count];

                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("\nEnter vehicle type (1-Car, 2-Bike, 3-Truck): ");
                    int choice = int.Parse(Console.ReadLine());

                    Vehicle v;

                    if (choice == 1)
                        v = new Car();
                    else if (choice == 2)
                        v = new Bike();
                    else
                        v = new Truck();

                    Console.Write("Enter vehicle number: ");
                    v.VehicleNumber = Console.ReadLine();

                    Console.Write("Enter vehicle type name: ");
                    v.Type = Console.ReadLine();

                    Console.Write("Enter rental rate per day: ");
                    v.RentalRate = double.Parse(Console.ReadLine());

                    Console.Write("Enter insurance policy number: ");
                    string policy = Console.ReadLine();

                    if (v is Car car)
                        car.SetPolicyNumber(policy);
                    else if (v is Bike bike)
                        bike.SetPolicyNumber(policy);
                    else if (v is Truck truck)
                        truck.SetPolicyNumber(policy);

                    vehicles[i] = v;
                }

                Console.Write("\nEnter number of rental days: ");
                int days = int.Parse(Console.ReadLine());

                Console.WriteLine("\nVehicle rental details");

                for (int i = 0; i < vehicles.Length; i++)
                {
                    vehicles[i].DisplayVehicle();

                    Console.WriteLine("Rental cost : " +
                        vehicles[i].CalculateRentalCost(days));

                    if (vehicles[i] is IInsurable ins)
                    {
                        Console.WriteLine("Insurance cost : " + ins.CalculateInsurance());
                        Console.WriteLine(ins.GetInsuranceDetails());
                    }

                    Console.WriteLine();
                }
            }
        }
    }

