using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level1
{
    internal class MultipleValues
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[10];
            int count = 0;

            // Take input until 0 and negative
            for (int i = 0; i < arr.Length; i++)
            {
                int value = int.Parse(Console.ReadLine());
                if (value <= 0)
                {
                    break;
                }
                arr[i] = value;
                count++;
            }
            int sum = 0;

            // Display values and calculate sum
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                sum = sum + arr[i];
            }
           
            
            Console.WriteLine(sum);

        }
    }
}
