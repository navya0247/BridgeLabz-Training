using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.extraBuiltIn.level2
{
    internal class Fibonacci
    {
       
        // function to print fibonacci series
        static void PrintFibonacci(int n)
        {
            int a = 0;
            int b = 1;
            int c;

            // print first two terms
            Console.Write(a + " " + b + " ");

            for (int i = 3; i <= n; i++)
            {
                c = a + b;      // built-in 
                Console.Write(c + " ");
                a = b;
                b = c;
            }
        }

        public static void Main(string[] args)
        {
            // take input from user
            int terms = Convert.ToInt32(Console.ReadLine());

            PrintFibonacci(terms);
        }
    }

}

