using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.methods.level3
{
    internal class NumberCheckerFour
    {
        // a) prime number check
        public static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        // b) neon number check 
        public static bool IsNeon(int number)
        {
            int square = number * number;
            int sum = 0;

            while (square > 0)
            {
                sum += square % 10;
                square /= 10;
            }

            return sum == number;
        }

        // c) spy number check 
        public static bool IsSpy(int number)
        {
            int sum = 0;
            int product = 1;
            int temp = number;

            while (temp > 0)
            {
                int digit = temp % 10;
                sum += digit;
                product *= digit;
                temp /= 10;
            }

            return sum == product;
        }

        // d) automorphic number check 
        public static bool IsAutomorphic(int number)
        {
            int square = number * number;
            string numStr = number.ToString();
            string squareStr = square.ToString();

            return squareStr.EndsWith(numStr);
        }

        // e) buzz number check
        public static bool IsBuzz(int number)
        {
            return (number % 7 == 0) || (number % 10 == 7);
        }
        public static void Main(string[] args)
        {
            //take input from user
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Prime Number " + (IsPrime(num) ? "Yes" : "No"));
            Console.WriteLine("Neon Number " + (IsNeon(num) ? "Yes" : "No"));
            Console.WriteLine("Spy Number  " + (IsSpy(num) ? "Yes" : "No"));
            Console.WriteLine("Automorphic Number " + (IsAutomorphic(num) ? "Yes" : "No"));
            Console.WriteLine("Buzz Number " + (IsBuzz(num) ? "Yes" : "No"));
        }
    }
}
