using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.encapsulation
{
        // interface for GPS related work
        interface IGPS
        {
            string GetCurrentLocation();
            void UpdateLocation(string newLocation);
        }

        // abstract base class
        abstract class Vehicle
        {
            // encapsulation using private fields
            private int vehicleId;
            private string driverName;
            private double ratePerKm;

            public int VehicleId
            {
                get { return vehicleId; }
                set { vehicleId = value; }
            }

            public string DriverName
            {
                get { return driverName; }
                set { driverName = value; }
            }

            public double RatePerKm
            {
                get { return ratePerKm; }
                set { ratePerKm = value; }
            }

            // abstract method
            public abstract double CalculateFare(double distance);

            // concrete method
            public void GetVehicleDetails()
            {
                Console.WriteLine("Vehicle ID  : " + VehicleId);
                Console.WriteLine("Driver Name : " + DriverName);
                Console.WriteLine("Rate/Km    : " + RatePerKm);
            }
        }

        // car class
        class Car : Vehicle, IGPS
        {
            private string location;

            public override double CalculateFare(double distance)
            {
                return distance * RatePerKm;
            }

            public string GetCurrentLocation()
            {
                return location;
            }

            public void UpdateLocation(string newLocation)
            {
                location = newLocation;
            }
        }

        // bike class
        class Bike : Vehicle, IGPS
        {
            private string location;

            public override double CalculateFare(double distance)
            {
                return (distance * RatePerKm) - 20; // discount for bike
            }

            public string GetCurrentLocation()
            {
                return location;
            }

            public void UpdateLocation(string newLocation)
            {
                location = newLocation;
            }
        }

        // auto class
        class Auto : Vehicle, IGPS
        {
            private string location;

            public override double CalculateFare(double distance)
            {
                return (distance * RatePerKm) + 30; 
            }

            public string GetCurrentLocation()
            {
                return location;
            }

            public void UpdateLocation(string newLocation)
            {
                location = newLocation;
            }
        }

        // main class
        internal class RideHailingApplication
        {
            public static void Main(string[] args)
            {
                Console.Write("Enter number of vehicles: ");
                int count = int.Parse(Console.ReadLine());

                // array of Vehicle reference for polymorphism
                Vehicle[] vehicles = new Vehicle[count];

                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("\nEnter vehicle type (1-Car, 2-Bike, 3-Auto): ");
                    int choice = int.Parse(Console.ReadLine());

                    Vehicle v;

                    if (choice == 1)
                        v = new Car();
                    else if (choice == 2)
                        v = new Bike();
                    else
                        v = new Auto();

                    Console.Write("Enter vehicle id: ");
                    v.VehicleId = int.Parse(Console.ReadLine());

                    Console.Write("Enter driver name: ");
                    v.DriverName = Console.ReadLine();

                    Console.Write("Enter rate per km: ");
                    v.RatePerKm = double.Parse(Console.ReadLine());

                    Console.Write("Enter current location: ");
                    string loc = Console.ReadLine();

                    if (v is IGPS gps)
                    {
                        gps.UpdateLocation(loc);
                    }

                    vehicles[i] = v;
                }

                Console.Write("\nEnter travel distance (km): ");
                double distance = double.Parse(Console.ReadLine());

                Console.WriteLine("\nRide details and fare");

                for (int i = 0; i < vehicles.Length; i++)
                {
                    vehicles[i].GetVehicleDetails();

                    Console.WriteLine("Fare Amount : " +
                        vehicles[i].CalculateFare(distance));

                    if (vehicles[i] is IGPS gps)
                    {
                        Console.WriteLine("Location    : " +
                            gps.GetCurrentLocation());
                    }

                    Console.WriteLine();
                }
            }
        }
    }

