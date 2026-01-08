using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased.smartHomeAutomation
{
    //AC class inherits Appliance
    internal class Ac:Appliance
    {
      
            public Ac() : base("AC") { }

            // Overriding (Polymorphism)
            public override void TurnOn()
            {
                Console.WriteLine("AC is turned ON at 24°C cooling mode.");
            }

            // Overriding (Polymorphism)
            public override void TurnOff()
            {
                Console.WriteLine("AC is turned OFF.");
            }
        }
    }

