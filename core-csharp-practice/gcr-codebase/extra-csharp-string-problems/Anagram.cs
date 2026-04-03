using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.extraString
{
    internal class Anagram
    {
        public static void Main(string[] args)
        {
            // take input from user
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();

            // if lengths differ not an anagram
            if (s1.Length != s2.Length)
            {
                Console.WriteLine("Not Anagrams");
                return;
            }

            bool[] arr = new bool[s2.Length]; 

            for (int i = 0; i < s1.Length; i++)
            {
                bool found = false;

                for (int j = 0; j < s2.Length; j++)
                {
                    if (s1[i] == s2[j] && arr[j] == false)
                    {
                        arr[j] = true;
                        found = true;
                        break;
                    }
                }

                // if any character from s1 not found in s2
                if (found == false)
                {
                    Console.WriteLine("Not Anagrams");
                    return;
                }
            }

            Console.WriteLine("Strings are Anagrams");
        }
    }

}

