using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.methods.level2
{
    internal class RecursiveNatural
    {
        // Method using formula
        public static int CalculateSumFormula(int number)
        {
            return number * (number + 1) / 2;
        }
        // Method using recursion
        public static int CalculateSumRecursion(int number)
        {
            if (number == 0)
            {
                return 0;
            }
            else
            {
                return number + CalculateSumRecursion(number - 1);
            }

        }
        public static void Main(String[] args)
        {

            //take no as input from user
            int number = int.Parse(Console.ReadLine());


            // check for natural number
            if (number <= 0)
            {
                Console.WriteLine("Not a natural number");
            }
            int result1 = CalculateSumFormula(number);
            int result2 = CalculateSumRecursion(number);
            Console.WriteLine("Sum of natural numbers using formula " + result1);
            Console.WriteLine("Sum of natural numbers using formula " + result2);

            // compare results
            if (result1 == result2)
            {
                Console.WriteLine("Both computations give same result");
            }
            else
            {
                Console.WriteLine("Both computations does not give same result");
            }
            }
        }
    }


