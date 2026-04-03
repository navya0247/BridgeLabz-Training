using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased.birdSanctuarySystem
{
    internal class BirdSanctuary
    {
        public static void Main(string[] args)
        {
            Bird[] birds = new Bird[5];
            birds[0] = new Eagle("Eagle", "Brown");
            birds[1] = new Sparrow("Sparrow", "Grey");
            birds[2] = new Duck("Duck", "White");
            birds[3] = new Penguin("Penguin", "Black");
            birds[4] = new Seagull("Seagull", "White");

            Console.WriteLine("Birds Sanctuary Details");

            for (int i = 0; i < birds.Length; i++)
            {
                birds[i].DisplayInfo();
                if (birds[i] is IFlyable fly)
                {
                    fly.Fly();
                }
                if (birds[i] is ISwimmable swim)
                {
                    swim.Swim();
                }
                Console.WriteLine();
            }

        }
    }

}