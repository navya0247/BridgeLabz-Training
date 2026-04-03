using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level1
{
    internal class Factor
    {
        public static void Main(string[] args)
        {
            // Take input from user
            int number = int.Parse(Console.ReadLine());

            // Check for natural number
            if (number <= 0)
            {
                Console.WriteLine("Please enter a natural number");
                return;
            }

            // Initial array size
            int maxFactor = 10;
            int[] factors = new int[maxFactor];
            int index = 0;

            // Find factors
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    // If array is full, increase size
                    if (index == maxFactor)
                    {
                        maxFactor = maxFactor * 2;
                        int[] temp = new int[maxFactor];

                        // Copy old elements to new array
                        for (int j = 0; j < factors.Length; j++)
                        {
                            temp[j] = factors[j];
                        }

                        factors = temp;
                    }

                    factors[index] = i;
                    index++;
                }
            }

           
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(factors[i] + " ");
            }
        }
    }
}
