using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.strings
{
    internal class Substring
    {
        //method to create substrings
        public void SubStr(string s1)
        {
            // i starting index
            //j ending index
           for(int i = 0; i < s1.Length; i++)
            {
                for(int j = i; j < s1.Length; j++)
                {
                    Console.WriteLine($"i={i}, j={j}");
                }
            }


        }

        public static void Main(string[] args)
        {    
            //input from user
            string s1 = Console.ReadLine();

            Substring obj = new Substring();
            obj.SubStr(s1);
            
            
        }
    }
}
