using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.methods.level2
{
    internal class CheckNumber
    {
        // Method to check whether number is positive
        public static bool IsPositive(int number)
        {
            return number > 0;
        }

        // Method to check whether number is even
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        // Method to compare two numbers
        public static int Compare(int number1, int number2)
        {
            if (number1 > number2)
            {
                return 1;
            }
            else if (number1 == number2)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public static void Main(string[] args)
        {
            int[] numbers = new int[5];

            // take input from user
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // loop through array and check each number
            for (int i = 0; i < numbers.Length; i++)
            {
                int num = numbers[i];

                // number is positive
                if (IsPositive(num))
                {
                    if (IsEven(num))
                        Console.WriteLine(num + " is Positive and Even");
                    else
                        Console.WriteLine(num + " is Positive and Odd");
                }
                else if (num == 0)
                {
                    // number is zero
                    Console.WriteLine(num + " is Zero");
                }
                else
                {
                    // number is negative
                    Console.WriteLine(num + " is Negative");
                }
            }

            // Compare first and last elements of the array

            int first = numbers[0];
            int last = numbers[numbers.Length - 1];
            int comparison = Compare(first, last);

            if (comparison == 1)
            {
                Console.WriteLine(first + " is greater than " + last);
            }
            else if (comparison == 0)
            {
                Console.WriteLine(first + " is equal to " + last);
            }
            else
            {
                Console.WriteLine(first + " is less than " + last);
            }
        }
    }
}
