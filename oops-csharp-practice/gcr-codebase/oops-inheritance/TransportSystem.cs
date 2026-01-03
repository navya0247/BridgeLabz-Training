using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.inheritance
{
    internal class TransportSystem
    {
            public int maxSpeed;
            public string fuelType;

            // Constructor for common values
            public TransportSystem(int maxSpeed, string fuelType)
            {
                this.maxSpeed = maxSpeed;
                this.fuelType = fuelType;
            }

            // Method to display vehicle info
            public virtual void DisplayInfo()
            {
                Console.WriteLine("Max Speed : " + maxSpeed);
                Console.WriteLine("Fuel Type: " + fuelType);
            }
        }

        // Car class
        class Car : TransportSystem
    {
            public int seatCapacity;

            public Car(int maxSpeed, string fuelType, int seatCapacity)
                : base(maxSpeed, fuelType)
            {
                this.seatCapacity = seatCapacity;
            }

            public override void DisplayInfo()
            {
                Console.WriteLine("\nVehicle Type: Car");
                base.DisplayInfo();
                Console.WriteLine("Seat Capacity: " + seatCapacity);
            }
        }

        // Truck class
        class Truck : TransportSystem
    {
            public int payloadCapacity;

            public Truck(int maxSpeed, string fuelType, int payloadCapacity)
                : base(maxSpeed, fuelType)
            {
                this.payloadCapacity = payloadCapacity;
            }

            public override void DisplayInfo()
            {
                Console.WriteLine("\nVehicle Type: Truck");
                base.DisplayInfo();
                Console.WriteLine("Payload Capacity: " + payloadCapacity + " kg");
            }
        }

        // Motorcycle class
        class Motorcycle : TransportSystem
    {
            public bool hasSidecar;

            public Motorcycle(int maxSpeed, string fuelType, bool hasSidecar)
                : base(maxSpeed, fuelType)
            {
                this.hasSidecar = hasSidecar;
            }

            public override void DisplayInfo()
            {
                Console.WriteLine("\nVehicle Type: Motorcycle");
                base.DisplayInfo();
                Console.WriteLine("Has Sidecar: " + hasSidecar);
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
            // Vehicle array (polymorphism)
            TransportSystem[] vehicles = new TransportSystem[3];

                // Car input
                Console.WriteLine("Enter Car Details:");
                vehicles[0] = new Car(
                    int.Parse(Console.ReadLine()),   // max speed
                    Console.ReadLine(),              // fuel type
                    int.Parse(Console.ReadLine())    // seat capacity
                );

                // Truck input
                Console.WriteLine("\nEnter Truck Details:");
                vehicles[1] = new Truck(
                    int.Parse(Console.ReadLine()),   // max speed
                    Console.ReadLine(),              // fuel type
                    int.Parse(Console.ReadLine())    // payload
                );

                // Motorcycle input
                Console.WriteLine("\nEnter Motorcycle Details:");
                vehicles[2] = new Motorcycle(
                    int.Parse(Console.ReadLine()),   // max speed
                    Console.ReadLine(),              // fuel type
                    bool.Parse(Console.ReadLine())   // sidecar
                );

                // Displaying all vehicle details
                Console.WriteLine("\n Vehicle Information ");
                for (int i = 0; i < vehicles.Length; i++)
                {
                    vehicles[i].DisplayInfo(); 
                }
            }
        }
    }

