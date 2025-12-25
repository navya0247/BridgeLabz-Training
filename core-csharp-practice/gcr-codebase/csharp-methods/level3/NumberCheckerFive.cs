using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.methods.level3
{
    internal class NumberCheckerFive
    {
        // a) method to find factors of a number and return array
        public static int[] GetFactors(int number)
        {
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                    count++;
            }

            int[] factors = new int[count];
            int index = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                    factors[index++] = i;
            }

            return factors;
        }

        // b) greatest factor using factors array 
        public static int GreatestFactor(int[] factors)
        {
            int max = factors[0];
            for (int i = 1; i < factors.Length; i++)
            {
                if (factors[i] > max)
                    max = factors[i];
            }
            return max;
        }

        // c) sum of factors
        public static int SumOfFactors(int[] factors)
        {
            int sum = 0;
            foreach (int f in factors)
            {
                sum += f;
            }
            return sum;
        }

        // d) product of factors
        public static int ProductOfFactors(int[] factors)
        {
            int product = 1;
            foreach (int f in factors)
            {
                product *= f;
            }
            return product;
        }

        // e) product of cube of factors 
        public static double ProductOfCubeOfFactors(int[] factors)
        {
            double result = 1;
            foreach (int f in factors)
            {
                result *= Math.Pow(f, 3); 
            }
            return result;
        }

        // f) perfect number check 
        public static bool IsPerfectNumber(int number, int[] factors)
        {
            int sum = 0;
            foreach (int f in factors)
            {
                if (f != number)  
                    sum += f;
            }
            return sum == number;
        }

        public static void Main(string[] args)
        {
           //take input from user
            int number = int.Parse(Console.ReadLine());

            int[] factors = GetFactors(number);
            foreach (int f in factors)
            {
                Console.Write(f + " ");
            }

            Console.WriteLine("Greatest Factor: " + GreatestFactor(factors));
            Console.WriteLine("Sum of Factors: " + SumOfFactors(factors));
            Console.WriteLine("Product of Factors: " + ProductOfFactors(factors));
            Console.WriteLine("Product of Cube of Factors: " + ProductOfCubeOfFactors(factors));

            Console.WriteLine("Perfect Number? " + (IsPerfectNumber(number, factors) ? "Yes" : "No"));
        }
    }
}
