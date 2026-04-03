using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.keywordsAndOperator
{
    internal class VehicleSystem
    {
        
            // static registration fee 
            public static double registrationFee;

            // readonly registration number
            public readonly string regNumber;

            // instance variables
            public string ownerName;
            public string vehicleType;

            // constructor using this keyword
            public VehicleSystem(string regNumber, string ownerName, string vehicleType)
            {
                this.regNumber = regNumber;
                this.ownerName = ownerName;
                this.vehicleType = vehicleType;
            }

            // static method to update registration fee
            public static void UpdateRegistrationFee(double newFee)
            {
                registrationFee = newFee;
            }

            // method to show vehicle details
            public void ShowDetails()
            {
                Console.WriteLine("Owner Name        : " + ownerName);
                Console.WriteLine("Vehicle Type     : " + vehicleType);
                Console.WriteLine("Registration No  : " + regNumber);
                Console.WriteLine("Registration Fee : " + registrationFee);
            }
        }

        class Program
        {
            public static void Main(string[] args)
            {
                // ask registration fee from user
                Console.WriteLine("Enter Registration Fee:");
                double fee = double.Parse(Console.ReadLine());
            VehicleSystem.UpdateRegistrationFee(fee);

                Console.WriteLine();

                // take vehicle details
                Console.WriteLine("Enter Registration Number:");
                string regNo = Console.ReadLine();

                Console.WriteLine("Enter Owner Name:");
                string owner = Console.ReadLine();

                Console.WriteLine("Enter Vehicle Type:");
                string type = Console.ReadLine();

            // create vehicle object
            VehicleSystem v1 = new VehicleSystem(regNo, owner, type);

                Console.WriteLine();

                // check object using is operator
                if (v1 is VehicleSystem)
                {
                    Console.WriteLine("Valid Vehicle Object\n");
                    v1.ShowDetails();
                }
                else
                {
                    Console.WriteLine("Invalid Object");
                }

                Console.ReadLine();
            }
        }
    }


