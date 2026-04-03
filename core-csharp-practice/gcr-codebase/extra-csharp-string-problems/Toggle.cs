using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.extraString
{
    internal class Toggle
    {
        public static void Main(string[] args)
        {
            //take input from user
            string s1 = Console.ReadLine();
            string result = "";

            for (int i = 0; i < s1.Length; i++)
            {
                char ch = s1[i];

                if (ch >= 'a' && ch <= 'z')
                {
                    result += (char)(ch - 32);               // make uppercase
                }
                else if (ch >= 'A' && ch <= 'Z')
                {
                    result += (char)(ch + 32);               // make lowercase
                }
                else
                {
                    result += ch; 
                }
            }

            //Display Result
            Console.WriteLine("Toggled " + result);
        }
    }

}

