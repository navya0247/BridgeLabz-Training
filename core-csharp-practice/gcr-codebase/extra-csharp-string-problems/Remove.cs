using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.extraString
{
    internal class Remove
    {
        public static void Main(string[] args)
        {
            // take  input from user
            string s1 = Console.ReadLine();

             // character to remove
            char removeChar = Console.ReadLine()[0];

            string result = "";

            // iterate through each character
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != removeChar)
                {
                    result += s1[i];
                }
            }

            // display Result
            Console.WriteLine("Modified String: " + result);
        }
    }

}

