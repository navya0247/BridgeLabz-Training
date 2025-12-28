using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.extraBuiltIn.level2
{
    internal class Palindrome
    {
        static string ReverseString(string s)
        {
            string r = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                r += s[i];  
            }
            return r;
        }

        static bool IsPalindrome(string s)
        {
            string rev = ReverseString(s);

            // built-in Equals 
            return s.Equals(rev);
        }

        public static void Main(string[] args)
        {
            //take input from user
            string num = Console.ReadLine();

            if (IsPalindrome(num))
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Palindrome");
        }
    }

}

