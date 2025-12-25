using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.methods.level3
{
    internal class NumberCheckerThree
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

        // b) reverse digits array
        public static int[] ReverseDigits(int[] digits)
        {
            int[] reversed = new int[digits.Length];
            int index = 0;

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                reversed[index++] = digits[i];
            }
            return reversed;
        }

        // c) compare two arrays
        public static bool AreArraysEqual(int[] arr1, int[] arr2)
        {
            if (arr1.Length != arr2.Length)
                return false;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                    return false;
            }
            return true;
        }

        // d) check palindrome using digits
        public static bool IsPalindrome(int[] digits)
        {
            int[] reversed = ReverseDigits(digits);
            return AreArraysEqual(digits, reversed);
        }

        // e) check duck number 
        public static bool IsDuckNumber(int[] digits)
        {
            foreach (int d in digits)
            {
                if (d != 0)     
                    return true;
            }
            return false;
        }

        public static void Main(string[] args)
        {
            //take input from user
            int number = int.Parse(Console.ReadLine());

            int[] digits = GetDigits(number);

            foreach (int d in digits)
                Console.Write(d + " ");

            int[] reversedDigits = ReverseDigits(digits);

            Console.Write("Reversed Digits ");
            foreach (int d in reversedDigits)
                Console.Write(d + " ");

            Console.WriteLine("Count of digits " + CountDigits(number));
            Console.WriteLine("Palindrome number " + (IsPalindrome(digits) ? "Yes" : "No"));
            Console.WriteLine("Duck number " + (IsDuckNumber(digits) ? "Yes" : "No"));
        }
    }
}
