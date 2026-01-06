using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased.birdSanctuarySystem
{
    internal class Sparrow:Bird,IFlyable
    {
        public Sparrow(string name,string color ):base(name,color)
        {

        }
        public void Fly()
        {
            Console.WriteLine("Sparrow is flying");

        }

    }
}
