using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level2
{
    internal class Frequency
    {
        public static void Main(string[] args)
        {
            // Take input number
            int number = int.Parse(Console.ReadLine());

            // Count digits
            int temp = number;
            int count = 0;
            while (temp > 0)
            {
                count++;
                temp = temp / 10;
            }

            // Create array to store digits
            int[] arr = new int[count];

            // Store digits in array
            temp = number;
            for (int i = 0; i < count; i++)
            {
                arr[i] = temp % 10;
                temp = temp / 10;
            }

            // Frequency array 
            int[] frequency = new int[10];

            // Calculate frequency
            for (int i = 0; i < arr.Length; i++)
            {
                frequency[arr[i]]++;
            }

            // Display frequency
            for (int i = 0; i < frequency.Length; i++)
            {
                if (frequency[i] > 0)
                {
                    Console.WriteLine("Frequency of digit " + i + " is " + frequency[i]);
                }
            }
        }
    }
}

