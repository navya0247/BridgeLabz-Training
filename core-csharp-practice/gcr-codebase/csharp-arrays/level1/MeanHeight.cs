using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level1
{
    internal class MeanHeight
    {
        public static void Main(string[] args)
        {

            // Create array of size 11
            double[] arr = new double[11];

            // Take input from user
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = double.Parse(Console.ReadLine());

            }

            // Calculate sum of heights
            double sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
               
                sum = sum + arr[i];
            }

            // Calculate mean
            double mean = sum / arr.Length;

            // Print result
            Console.WriteLine("Mean height is " + mean);



        }
    }
}
