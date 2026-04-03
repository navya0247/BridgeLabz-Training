using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level2
{
    internal class Digits
    {
        public static void Main(string[] args)
        {
            // Take input from user
            int number = int.Parse(Console.ReadLine());

            // Initial size of digits array
            int maxDigit = 10;
            int[] digits = new int[maxDigit];
            int index = 0;

            int temp = number;

            // Extract digits and store in array
            while (temp > 0)
            {
                
                if (index == maxDigit)
                {
                    maxDigit = maxDigit + 10;

                    // Create new temp array 
                    int[] tempArray = new int[maxDigit];

                    // Copy old digits to new array
                    for (int i = 0; i < digits.Length; i++)
                    {
                        tempArray[i] = digits[i];
                    }

                    // Assign new array to digits
                    digits = tempArray;
                }

                digits[index] = temp % 10;
                index++;
                temp = temp / 10;
            }

            // Initialize largest and second largest
            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            // Find largest and second largest digits
            for (int i = 0; i < index; i++)
            {
                if (digits[i] > largest)
                {
                    secondLargest = largest;
                    largest = digits[i];
                }
                else if (digits[i] > secondLargest && digits[i] != largest)
                {
                    secondLargest = digits[i];
                }
            }

            // Print result
            Console.WriteLine("Largest digit is " + largest);
            Console.WriteLine("Second largest digit is " + secondLargest);
        }
    }
}

