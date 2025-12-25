using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.methods.level3
{
    internal class Euclidean
    {
        // b) Method to find Euclidean distance between two points
        public static double FindDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return distance;
        }

        // d) Method to find slope (m) and y-intercept (b) of the line
        public static double[] FindLineEquation(double x1, double y1, double x2, double y2)
        {
            double m = (y2 - y1) / (x2 - x1);  // slope
            double b = y1 - (m * x1);         // y-intercept

            return new double[] { m, b };     
        }

        public static void Main(string[] args)
        {
            // a) take input from user
            double x1 = double.Parse(Console.ReadLine());

            double y1 = double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());

            double y2 = double.Parse(Console.ReadLine());

            // calculate distance
            double distance = FindDistance(x1, y1, x2, y2);
            Console.WriteLine("Euclidean Distance  " + distance);

            // calculate line equation
            double[] lineValues = FindLineEquation(x1, y1, x2, y2);
            double slope = lineValues[0];
            double intercept = lineValues[1];

            Console.WriteLine("Slope " + slope);
            Console.WriteLine("Y-intercept " + intercept);

            Console.WriteLine($"Equation of the line: y = {slope}x + {intercept}");
        }
    }
}
