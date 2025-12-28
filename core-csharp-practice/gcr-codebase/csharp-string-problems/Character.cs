using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.strings
{
    internal class Character
    {
        //method to convert string to character array
        public static char[] ReturnCharacter(string s1)
        {
            char[] chars = new char[s1.Length];
            for(int i = 0; i < s1.Length; i++)
            {
                chars[i] = s1[i];

            }
            return chars;

        }

        public static void Main(string[] args)
        {
            //input from user
            string s1 = Console.ReadLine();

            //Method call
            char[] result1 = ReturnCharacter(s1);
            

            char[] result2 = s1.ToCharArray();                 //using built-in method

            Console.WriteLine(new string(result1));
            Console.WriteLine(new string(result2));
        }
    }
}
