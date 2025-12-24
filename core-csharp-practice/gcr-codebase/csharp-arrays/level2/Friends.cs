using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level2
{
    internal class Friends
    {
        public static void Main(string[] args)
        {
            // Names of friends
            string[] names = { "Amar", "Akbar", "Anthony" };

            // create arrays for age and height
            int[] age = new int[3];
            double[] height = new double[3];

            // Take input from user
            for (int i = 0; i < 3; i++)
            {
                
                age[i] = int.Parse(Console.ReadLine());
                height[i] = double.Parse(Console.ReadLine());
            }

            // Assume first friend is youngest and tallest
            int youngestIndex = 0;
            int tallestIndex = 0;

            // Find youngest and tallest
            for (int i = 1; i < 3; i++)
            {
                if (age[i] < age[youngestIndex])
                {
                    youngestIndex = i;
                }

                if (height[i] > height[tallestIndex])
                {
                    tallestIndex = i;
                }
            }

            // Display results
            Console.WriteLine("Youngest Friend " + names[youngestIndex]);
           Console.WriteLine("Tallest Friend " + names[tallestIndex]);
        }
    }
}
