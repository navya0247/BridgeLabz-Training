using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased
{
    internal class DistanceTracker
    {
        
            // instance variables
            string busNumber;
            string routeName;
            int totalDistance = 0;

            // constructor to take bus details
            public DistanceTracker(string busNumber, string routeName)
            {
                this.busNumber = busNumber;
                this.routeName = routeName;
            }

            // method to add distance for a stop
            public void AddStopDistance()
            {
                Console.Write("Enter distance for this stop (in km): ");
                int distance = int.Parse(Console.ReadLine());

                totalDistance = totalDistance + distance;

                Console.WriteLine("Total Distance Covered: " + totalDistance + " km");
            }

            // method to ask passenger exit
            public bool WantToGetOff()
            {
                Console.Write("Do you want to get off? (yes/no): ");
                string choice = Console.ReadLine();

                if (choice == "yes" || choice == "Yes")
                {
                    return true;
                }
                return false;
            }

            // method to show final details
            public void ShowSummary()
            {
                Console.WriteLine("\nBus Number  : " + busNumber);
                Console.WriteLine("Route Name : " + routeName);
                Console.WriteLine("Total Distance Travelled: " + totalDistance + " km");
            }
        }

        class Program
        {
            public static void Main(string[] args)
            {
                // ask bus details from user
                Console.Write("Enter Bus Number: ");
                string busNo = Console.ReadLine();

                Console.Write("Enter Route Name: ");
                string route = Console.ReadLine();

            // create object
            DistanceTracker bus = new DistanceTracker(busNo, route);

                int choice;

                while (true)
                {
                    // menu
                    Console.WriteLine("\n Bus Route Distance Tracker");
                    Console.WriteLine("1. Add Stop Distance");
                    Console.WriteLine("2. End Journey");
                    Console.Write("Enter your choice: ");

                    choice = int.Parse(Console.ReadLine());

                    if (choice == 1)
                    {
                        bus.AddStopDistance();

                        // ask passenger confirmation
                        if (bus.WantToGetOff())
                        {
                            bus.ShowSummary();
                            break;
                        }
                    }
                    else if (choice == 2)
                    {
                        bus.ShowSummary();
                        Console.WriteLine("Passenger got off.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid menu choice.");
                    }
                }

                Console.WriteLine("Journey Ended.");
                Console.ReadLine();
            }
        }
    }

