using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level1
{
    internal class CheckNumber
    {
        public static void Main(string[] args)
        {

            int[] arr = new int[5];

            // Take input
            for (int i = 0; i <arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            // Check each number
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    Console.WriteLine("The number is positive");

                    // Even or Odd check for positive numbers
                    if (arr[i] % 2 == 0)
                    {
                        Console.WriteLine("The number is even");
                    }
                    else
                    {
                        Console.WriteLine("The number is odd");
                    }
                }
                else if (arr[i] < 0)
                {
                    Console.WriteLine("The number is negative");
                }
                else
                {
                    Console.WriteLine("The number is zero");
                }
            }
            // Compare first and last elements
            if (arr[0] == arr[4])
                    {
                Console.WriteLine("First and last are equal");
                    }
            else if (arr[0] > arr[4])
            {
                Console.WriteLine("First is greater than last number");
            }
        }
            }
        }
    

