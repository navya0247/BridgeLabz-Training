using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.methods.level2
{
    internal class FactorNo
    {
        // Method to find factors
        public static int[] CalculateFactor(int number)
        {
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;

                }
            }

            // Store factors in array
            int[] factors = new int[count];
            int index = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0) { 
                factors[index++] = i;
            }
        }
               return factors;
            }

        // Method to find sum
        public static int sumOfFactors(int[] factors)
        {
            int sum = 0;
            for(int i = 0; i < factors.Length; i++)
            {
                sum += factors[i];
            }
            return sum;
        }

        // Method to find product
        public static int ProductOfFactors(int[] factors)
        {
            int product = 1;
        for(int i=0;i<factors.Length;i++)
            {
                product = product * factors[i];
            }
            return product;
        }


        // Method to find sum of squares
        public static double SumOfSquares(int[] factors)
        {
            double sumSquares = 0;
            for (int i = 0; i < factors.Length; i++)
            {
                sumSquares += Math.Pow(factors[i], 2);
            }
            return sumSquares;
        }

        public static void Main(string[] args)
        {
            //take input from user
            int number = int.Parse(Console.ReadLine());

            // Get factors
            int[] factors = CalculateFactor(number);
            for(int i = 0; i < factors.Length; i++)
            {
                Console.WriteLine(factors[i]);
            }

            //Method Call
            int sum = sumOfFactors(factors);
            int product = ProductOfFactors(factors);
            double sumSquares = SumOfSquares(factors);

            Console.WriteLine("Sum of factors " + sum);
            Console.WriteLine("Product of factors " + product);
            Console.WriteLine("SumOfSquares factors " + sumSquares);

        }

    }

                
            }
        

    

