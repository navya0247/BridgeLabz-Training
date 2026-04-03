using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.extraString
{
    internal class Count
    {
        public static void Main(string[] args)
        {

            //input from user
            string s1 = Console.ReadLine();

            //initialize counts
            int vowels = 0;
            int consonants = 0;

            for (int i = 0; i < s1.Length; i++)
            {
                char ch = s1[i];
                if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
                {
                    char c = Char.ToLower(ch);
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                        vowels++;
                    else
                        consonants++;
                }
            }

            //Display Results
            Console.WriteLine("Vowels " + vowels);
            Console.WriteLine("Consonant " + consonants);
        }
    }
}

