using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased.smartHomeAutomation
{
        internal class SmartHomeMenu
        {
            // Variable to store selected appliance
            private Appliance appliance;

            // Method to display menu
            public void ShowMenu()
            {
                Console.WriteLine("Smart Home Automation System");
                Console.WriteLine("1. Turn ON Light");
                Console.WriteLine("2. Turn ON Fan");
                Console.WriteLine("3. Turn ON AC");
                Console.WriteLine("4. Turn OFF Appliance");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        appliance = new Light();
                        appliance.TurnOn();
                        break;

                    case 2:
                        appliance = new Fan();
                        appliance.TurnOn();
                        break;

                    case 3:
                        appliance = new Ac();
                        appliance.TurnOn();
                        break;

                    case 4:
                        if (appliance != null)
                            appliance.TurnOff();
                        else
                            Console.WriteLine("No appliance is currently ON.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }


