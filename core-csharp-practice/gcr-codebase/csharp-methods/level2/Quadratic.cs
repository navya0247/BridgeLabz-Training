using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.methods.level2
{
    internal class Quadratic
    {
        // Method to calculate roots and return them as an array
        public static double[] FindRoots(double a, double b, double c)
        {
            double delta = Math.Pow(b, 2) - (4 * a * c);

            // if delta is negative  no real roots
            if (delta < 0)
            {
                return new double[0]; 
            }

            // if delta is zero  one real root
            if (delta == 0)
            {
                double root = -b / (2 * a);
                return new double[] { root };
            }

            // if delta is positive  two real roots
            double sqrtDelta = Math.Sqrt(delta);
            double root1 = (-b + sqrtDelta) / (2 * a);
            double root2 = (-b - sqrtDelta) / (2 * a);

            return new double[] { root1, root2 };
        }

        public static void Main(string[] args)
        {
            // Take user input
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            //Method Call
            double[] roots = FindRoots(a, b, c);

            if (roots.Length == 0)
            {
                Console.WriteLine("No Real Roots");
            }
            else if (roots.Length == 1)
            {
                Console.WriteLine("One Real Root: " + roots[0]);
            }
            else
            {
                Console.WriteLine("Root 1 " + roots[0]);
                Console.WriteLine("Root 2 " + roots[1]);
            }
        }
    }
}
