using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased.birdSanctuarySystem
{
    internal class Duck:Bird,ISwimmable
    {
        public Duck(string name,string color):base(name,color)
        {

        }
        public void Swim()
        {
            Console.WriteLine("Duck is swimming");
        }
    }
}
