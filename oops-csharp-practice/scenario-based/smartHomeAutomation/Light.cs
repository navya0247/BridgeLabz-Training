using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased.smartHomeAutomation
{
    //Light class inherits Appliance
    internal class Light : Appliance
    {       
           public Light() : base("Light") { }

            // Overriding (Polymorphism)
            public override void TurnOn()
            {
                Console.WriteLine("Light is turned ON with normal brightness.");
            }

            // Overriding (Polymorphism)
            public override void TurnOff()
            {
                Console.WriteLine("Light is turned OFF.");
            }
        }
    }
