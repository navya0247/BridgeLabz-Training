/*using System;
using System.Collections.Generic;
using System.Text;


namespace BridgeLabzTraining.methods.level3
{
    internal class Players
    {
        //Method to find sum of height
        public static int FindSum(int[] heights)
        {
            int sum = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                sum += heights[i];
            }
            return sum;
        }

        //Method to find mean height
        public static double FindMean(int[] heights)
        {
            int sum = FindSum(heights);
            return (double)sum / heights.Length;
        }

        //Method to find shortest height
        public static int FindShortest(int[] heights)
        {
            int shortest = heights[0];
            for (int i = 1; i < heights.Length; i++)
            {
                if (heights[i] < shortest)
                {
                    shortest = heights[i];
                }
            }
            return shortest;
        }

        //Method to find tallest height
        public static int FindTallest(int[] heights)
        {
            int tallest = heights[0];
            for (int i = 1; i < heights.Length; i++)
            {
                if (heights[i] > tallest)
                {
                    tallest = heights[i];
                }
            }
            return tallest;
        }

        public static void Main(string[] args)
        {
  
            int[] heights = new int[11];
            Random rand = new Random();

            // generate 3 digit random heights between 150cm and 250cm
            for (int i = 0; i < heights.Length; i++)
            {
                heights[i] = rand.Next(150, 251);
            }

            // Display heights
            foreach (int height in heights)
            {
                Console.Write(height + " ");
            }
            Console.WriteLine();

            // Method Call
            int sum = FindSum(heights);
            double mean = FindMean(heights);
            int shortest = FindShortest(heights);
            int tallest = FindTallest(heights);

            // Display results
            Console.WriteLine("Shortest Height " + shortest );
            Console.WriteLine("Tallest Height " + tallest );
            Console.WriteLine("Mean Height " + mean );
        }
    }
}*/
