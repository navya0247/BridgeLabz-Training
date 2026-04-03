using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased.birdSanctuarySystem
{
    internal class Penguin:Bird,ISwimmable
    {
        public Penguin(string name,string color):base(name,color)
        {

        }

        public void Swim()
        {
            Console.WriteLine("Penguin is swimming");
        }
    }
}
