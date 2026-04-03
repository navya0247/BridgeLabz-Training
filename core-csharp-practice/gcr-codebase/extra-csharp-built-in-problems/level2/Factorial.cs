using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.extraBuiltIn.level2
{
    internal class Factorial
    {
        // recursive factorial function
        public static int CalFactorial(int n)
        {
            if (n == 0)
                return 1;
            return n * CalFactorial(n - 1); // multiplication built-in 
        }

        public static void Main(string[] args)
        {
            //take input from user
            int num = Convert.ToInt32(Console.ReadLine());
            int result = CalFactorial(num);

            //Print result
            Console.WriteLine("Factorial " + result);
        }
    }

}

