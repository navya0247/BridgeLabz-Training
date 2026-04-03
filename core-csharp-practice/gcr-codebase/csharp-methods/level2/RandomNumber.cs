using System;
using System.Collections.Generic;
using System.Text;


namespace BridgeLabzTraining.methods.level2
{
    internal class RandomNumber
    {
        // Method to generate 4-digit random array
        public static int[] Generate4DigitRandomArray(int size)
        {
            int[] randomNumbers = new int[size];
            Random rand = new Random();

            for (int i = 0; i < size; i++)
            {
                randomNumbers[i] = rand.Next(1000, 10000); // 4-digit number
            }

            return randomNumbers;
        }

        // Method to find average, min and max
        public static double[] FindAverageMinMax(int[] numbers)
        {
            double sum = 0;
            int min = numbers[0];
            int max = numbers[0];
           
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                min = Math.Min(min, numbers[i]);  // using Math.Min()
                max = Math.Max(max, numbers[i]);  // using Math.Max()
            }

            double average = sum / numbers.Length;
            return new double[] { average, min, max };
        }

        public static void Main(string[] args)
        {
            int[] randomNumbers = Generate4DigitRandomArray(5);
            double[] result = FindAverageMinMax(randomNumbers);

            foreach (int num in randomNumbers)
            {
                Console.WriteLine(num);
            }

            //Print results
            Console.WriteLine( result[0]);
            Console.WriteLine( result[1]);
            Console.WriteLine( result[2]);
        }
    }
}

