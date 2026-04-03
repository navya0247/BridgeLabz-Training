using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level2
{
    internal class Reverse
    {
        public static void Main(string[] args)
        {
            // Take input from user
            int number = int.Parse(Console.ReadLine());


            // Count digits
            int temp = number;
            int count = 0;
            while (temp > 0)
            {
                temp = temp / 10;
                count++;
            }

            //Create array to store digits
            int[] arr = new int[count];

            temp = number;

            // Store digits in array
            for (int i = 0; i < count; i++)
            {
                arr[i] = temp % 10;
                temp = temp / 10;
            }

            // Reverse number using array
            int reverse = 0;
            for(int i =0; i<arr.Length ; i++)
            {
                reverse = reverse * 10 + arr[i];
            }

            // Print result
            Console.WriteLine("Reverse number is " + reverse);
        }
    }
}
