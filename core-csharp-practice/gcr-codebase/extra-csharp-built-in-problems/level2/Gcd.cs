using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.extraBuiltIn.level2
{
    internal class Gcd
    {
       // function to find gcd 
        public static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // function to find lcm 
        static int LCM(int a, int b)
        {
            int gcd = GCD(a, b);
            return (a * b) / gcd;
        }

        public static void Main(string[] args)
        {
            //take input from user
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());

            //Print result
            Console.WriteLine("GCD " + GCD(n1, n2));
            Console.WriteLine("LCM " + LCM(n1, n2));
        }
    }

}

