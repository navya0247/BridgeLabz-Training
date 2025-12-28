using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.extraString
{
    internal class RemoveDuplicate
    {
        public static void Main(string[] args)
        {
            //take input from user
            string s1 = Console.ReadLine();
            string result = "";

            for (int i = 0; i < s1.Length; i++)
            {
                if (result.Contains(s1[i]) == false)
                {
                    result += s1[i];
                }
            }

            //Display Result
            Console.WriteLine("After removing duplicates " + result);
        }
    }

}

