using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.methods.level1
{
    internal class WindChill
    {
        //create the method to find wind chill temperature
        public static double CalculateWindChill(double temperature,double speed)
        {
            //formula to calculate wind chill temperature
            double windChill = 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * Math.Pow(speed, 0.16);
                return windChill;
        }

        public static void Main(string[] args)
        {
            //take input from user
            double temperature = double.Parse(Console.ReadLine());
            double speed = double.Parse(Console.ReadLine());

            //Method call
            double result = CalculateWindChill(temperature, speed);

            Console.WriteLine("The wind chill temperature is " + result);

        }   

            
    }
}
