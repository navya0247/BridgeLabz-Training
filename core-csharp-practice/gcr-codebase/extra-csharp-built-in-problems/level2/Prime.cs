using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.extraBuiltIn.level2
{
    internal class Prime
    {       
        public static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;

            // using built-in Math.Sqrt 
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

          public static void Main(string[] args) 
        {
            //take input from user
            int num = Convert.ToInt32(Console.ReadLine());

            if (IsPrime(num))
                Console.WriteLine(num + " is Prime");
            else
                Console.WriteLine(num + " is Not Prime");
        }
    }

}

