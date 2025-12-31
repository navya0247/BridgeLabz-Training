/*using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.constructors
{
    internal class VehicleRegistration
    {
            public string ownerName;    // instance variable
            public string vehicleType;  // instance variable

            public static double registrationFee = 5000; // class variable

            public VehicleRegistration(string owner, string type)
            {
                ownerName = owner;
                vehicleType = type;
            }

            // instance method
            public void DisplayVehicleDetails()
            {
                Console.WriteLine("Owner Name: " + ownerName);
                Console.WriteLine("Vehicle Type: " + vehicleType);
                Console.WriteLine("Registration Fee: " + registrationFee);
            }

            // class method
            public static void UpdateRegistrationFee(double newFee)
            {
                registrationFee = newFee;
            }

            public static void Main(string[] args)
            {
            VehicleRegistration v1 = new VehicleRegistration("Navya", "Car");
            VehicleRegistration v2 = new VehicleRegistration("Aman", "Bike");

                v1.DisplayVehicleDetails();
                v2.DisplayVehicleDetails();

            VehicleRegistration.UpdateRegistrationFee(6500);

                v1.DisplayVehicleDetails();
                v2.DisplayVehicleDetails();
            }
        }
    }*/

