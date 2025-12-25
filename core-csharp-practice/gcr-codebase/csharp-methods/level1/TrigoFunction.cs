using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.methods.level1
{
    internal class TrigoFunction
    {
        // Method to calculate trigonometric functions
        public static double[] CalculateTrigonometricFunctions(double angle)
        {
            // Convert degrees to radians
            double radians = angle * Math.PI / 180;

            double sine = Math.Sin(radians);
            double cosine = Math.Cos(radians);
            double tangent = Math.Tan(radians);

            return new double[] { sine, cosine, tangent };
        }

        public static void Main(string[] args)
        {
            // Take angle input from user
            double angle = double.Parse(Console.ReadLine());

            // Method call
            double[] result = CalculateTrigonometricFunctions(angle);

            Console.WriteLine("Sine value  " + result[0]);
            Console.WriteLine("Cosine value  " + result[1]);
            Console.WriteLine("Tangent value  " + result[2]);
        }
    }
}

