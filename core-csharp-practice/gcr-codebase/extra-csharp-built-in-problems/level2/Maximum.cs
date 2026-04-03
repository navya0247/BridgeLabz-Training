using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.extraBuiltIn.level2
{
    internal class Maximum
    {
       public static void Main(string[] args)
        {
            // take input from user
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            // using built-in Math.Max 
            int max = Math.Max(a, Math.Max(b, c));

            //print result
            Console.WriteLine("Maximum number is " + max);
        }
    }

}

