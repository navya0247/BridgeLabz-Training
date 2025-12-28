using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.strings
{
    internal class Lowercase
    {
        // Method to convert string to lowercase using ascii logic
        public static string ConvertToLowercase(string s1)
        {
            char[] cha = new char[s1.Length];   // to store converted characters

            for (int i = 0; i < s1.Length; i++)
            {
                char ch = s1[i];

                // check if character is uppercase 
                if (ch >= 'A' && ch <= 'Z')
                {
                    // convert uppercase to lowercase 
                    cha[i] = (char)(ch + 32);
                }
                else
                {
                    cha[i] = ch;
                }
            }

            return new string(cha);  // convert char array back to string
        }

        public static void Main(string[] args)
        {
            // input string from user
            string s1 = Console.ReadLine();

            // using ascii logic
            string result1 = ConvertToLowercase(s1);

            // using built-in method
            string result2 = s1.ToLower();

            Console.WriteLine("Using ASCII logic " + result1);
            Console.WriteLine("Using string.ToLower() " + result2);
        }
    }
}
