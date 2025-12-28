using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.strings
{
    internal class Uppercase
    {
        // Method to convert string to uppercase  using ASCII logic
        public static string ConvertToUppercase(string s1)
        {
            char[] cha = new char[s1.Length];

            for (int i = 0; i < s1.Length; i++)
            {
                char ch = s1[i];

                // Check if character is lowercase 
                if (ch >= 'a' && ch <= 'z')
                {
                    // Convert lowercase to uppercase 
                    cha[i] = (char)(ch - 32);
                }
                else
                {
                    cha[i] = ch;
                }
            }

            return new string(cha);
        }

        public static void Main(string[] args)
        {
             //input string from user
            string s1 = Console.ReadLine();

            string result1 = ConvertToUppercase(s1);                        //using ascii
            string result2 = s1.ToUpper();                                  //built-in method

            Console.WriteLine("Using ASCII logic      " + result1);
            Console.WriteLine("Using string.ToUpper() " + result2); 
        }
    }
}
