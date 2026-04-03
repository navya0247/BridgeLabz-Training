using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level1
{
    internal class FizzBuzz
    {
        public static void Main(string[] args)
        {
            // Take input from user
            int number = int.Parse(Console.ReadLine());

            // Check for positive integer
            if (number <= 0)
            {
                Console.WriteLine("Please enter a positive integer");
                return;
            }

            // Create a string array 
            string[] result = new string[number + 1];

            // Loop from 1 to number 
            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result[i] = "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    result[i] = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    result[i] = "Buzz";
                }
                else
                {
                    result[i] = i.ToString();
                }
            }

            // Print the result array with position
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine("Position " + i + " = " + result[i]);
            }
        }
    }
}
