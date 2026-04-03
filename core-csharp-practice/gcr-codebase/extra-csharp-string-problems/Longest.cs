using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.extraString
{
    internal class Longest
    {
        public static void Main(string[] args)
        {
            //input from user
            string s1 = Console.ReadLine();
            string word = "";
            string longest = "";

            s1 = s1 + " ";                   // to detect last word

            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != ' ')
                {
                    word += s1[i];
                }
                else
                {
                    if (word.Length > longest.Length)
                    {
                        longest = word;
                    }
                    word = "";
                }
            }

            //Display Result
            Console.WriteLine("Longest word " + longest);
        }
    }

}

