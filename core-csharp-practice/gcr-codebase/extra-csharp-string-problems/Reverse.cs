using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.extraString
{
    internal class Reverse
    {
        public static void Main(string[] args)
        {
            //take input from user
            string s1 = Console.ReadLine();
            string rev = "";

            for (int i = s1.Length - 1; i >= 0; i--)
            {
                rev += s1[i];
            }

            //Display Result
            Console.WriteLine("Reverse " + rev);
        }
    }

}

