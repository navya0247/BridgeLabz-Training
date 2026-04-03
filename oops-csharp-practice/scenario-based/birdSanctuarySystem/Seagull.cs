using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased.birdSanctuarySystem
{
    internal class Seagull:Bird,IFlyable,ISwimmable
    {
        public Seagull(string name,string color):base(name,color)
        {

        }
        public void Fly()
        {
            Console.WriteLine("Seagull can Fly");
        }
        public void Swim()
        {
            Console.WriteLine("Seagull can swim");
        }
    }
}
