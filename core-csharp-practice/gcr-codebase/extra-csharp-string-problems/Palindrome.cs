using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.extraString
{
    internal class Palindrome
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

            //check for palindrome
            if (s1 == rev)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }
    }

}

