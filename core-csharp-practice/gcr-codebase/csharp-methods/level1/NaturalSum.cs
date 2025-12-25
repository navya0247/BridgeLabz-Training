using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.methods.level1
{
    internal class NaturalSum
    {
        //Method to Calculate sum
        public static int CalculateSum(int number)
        {
            int sum = 0;

            //loop to calculate the sum of input numbers
            for(int i = 1; i <= number; i++)
            {
                sum = sum + i;
            }
            return sum;
        }
        public static void Main(string[] args)
        {
            //Take input from user
            int number = int.Parse(Console.ReadLine());

            //Method call
            int result = CalculateSum(number);

            Console.WriteLine("Sum of natural numbers is " + result);

        }
    }
}
