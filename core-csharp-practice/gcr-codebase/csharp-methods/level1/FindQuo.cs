using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.methods.level1
{
    internal class FindQuo
    {
        //Method to find Quotient and Remainder
        public static int[] CalculateQuotientAndRemainder(int num1 ,int num2)
        {
            int quo = num1 / num2;                                     //calculate the quotient
            int rem = num1 % num2;                                     //calculate the remainder

            return new int[] { quo, rem };                             // store the quo and rem in an array


        }
        public static void Main(String[] args)
        {
            int num1 = int.Parse(Console.ReadLine());                //take first no from user
            int num2 = int.Parse(Console.ReadLine());                //take second no from user

            int[] result = CalculateQuotientAndRemainder(num1, num2); //Call Method
            Console.WriteLine("The Quotient is " + result[0] + " and Remainder is " + result[1] + " of two numbers " + num1 + " and " + num2);
        }
}
}
