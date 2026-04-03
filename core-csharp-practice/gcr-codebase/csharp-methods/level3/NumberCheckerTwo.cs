using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.methods.level3
{
    internal class NumberCheckerTwo
    {
        // a) count digits
        public static int CountDigits(int number)
        {
            int count = 0;
            while (number > 0)
            {
                number /= 10;
                count++;
            }
            return count;
        }
        public static int[] GetDigits(int number)
        {
            int size = CountDigits(number);
            int[] digits = new int[size];

            for (int i = size - 1; i >= 0; i--)
            {
                digits[i] = number % 10;
                number /= 10;
            }
            return digits;
        }

        // b) sum of digits
        public static int SumOfDigits(int[] digits)
        {
            int sum = 0;
            foreach (int d in digits)
            {
                sum += d;
            }
            return sum;
        }

        // c) sum of squares of digits
        public static int SumOfSquares(int[] digits)
        {
            int total = 0;
            foreach (int d in digits)
            {
                total += (int)Math.Pow(d, 2);
            }
            return total;
        }

        // d) Harshad number check
        public static bool IsHarshad(int number, int[] digits)
        {
            int digitSum = SumOfDigits(digits);
            return number % digitSum == 0;
        }

        // e) frequency of each digit
        public static int[,] DigitFrequency(int[] digits)
        {
            int[,] freq = new int[10, 2];

            for (int i = 0; i < 10; i++)
            {
                freq[i, 0] = i;
            }

            foreach (int d in digits)
            {
                freq[d, 1]++;
            }

            return freq;
        }
        public static void Main(string[] args)
        {
             //input from user
            int number = int.Parse(Console.ReadLine());

            int[] digits = GetDigits(number);

            foreach (int d in digits) Console.Write(d + " ");

            Console.WriteLine("Total digits " + CountDigits(number));
            Console.WriteLine("Sum of digits " + SumOfDigits(digits));
            Console.WriteLine("Sum of squares " + SumOfSquares(digits));

            Console.WriteLine("Harshad number? " +(IsHarshad(number, digits) ? "Yes" : "No"));

            int[,] freq = DigitFrequency(digits);
            for (int i = 0; i < 10; i++)
            {
                if (freq[i, 1] > 0)
                {
                    Console.WriteLine("Digit " + freq[i, 0] +" appears " + freq[i, 1] + " times");
                }
            }
        }
    }
}

