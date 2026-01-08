using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased.smartHomeAutomation
{
    //Fan class inherits Appliance
    internal class Fan : Appliance
    {
      
            public Fan() : base("Fan") { }

            // Overriding (Polymorphism)
            public override void TurnOn()
            {
                Console.WriteLine("Fan is turned ON at medium speed.");
            }

            // Overriding (Polymorphism)
            public override void TurnOff()
            {
                Console.WriteLine("Fan is turned OFF.");
            }
        }
    }


