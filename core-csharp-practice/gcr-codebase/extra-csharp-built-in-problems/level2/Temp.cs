using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.extraBuiltIn.level2
{
    internal class Temp
    {

       // convert F to C using formula
        public static double ConvertToCelsius(double f)
        {
            return (f - 32) * 5 / 9;
        }

        // convert C to F using formula
        public static double ConvertToFahrenheit(double c)
        {
            return (c * 9 / 5) + 32;
        }

        public  static void Main(string[] args)
        { 
            //take input from user
            int result1 = Convert.ToInt32(Console.ReadLine());                //choice 1 or 2
            double result2 = Convert.ToDouble(Console.ReadLine());           //value to be converted

            if (result1 == 1)
            {
                Console.WriteLine("Celsius " + ConvertToCelsius(result2));
            }
            else if (result1 == 2)
            {
                Console.WriteLine("Fahrenheit " + ConvertToFahrenheit(result2));
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }
    }

}

