using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased.birdSanctuarySystem
{
    internal class Bird
    {
        protected string name;
        protected string color;

        public Bird(string name,string color)
        {
            this.name = name;
            this.color = color;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Bird Name : " + name);
            Console.WriteLine("Color : " + color);

        }
       
    }
}
