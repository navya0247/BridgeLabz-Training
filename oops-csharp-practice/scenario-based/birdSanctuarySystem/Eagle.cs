using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased.birdSanctuarySystem
{
    internal class Eagle:Bird,IFlyable
    {
        public Eagle(string name,string color) : base(name, color) 
        { 
        }

        public void Fly()
        {
            Console.WriteLine("Eagle fly");
        }
    }
}
