using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.extraString
{
    internal class Frequent
    {
        public static void Main(string[] args)
        {    
            //take input from user
            string s1 = Console.ReadLine();
            bool[] counted = new bool[s1.Length];   // to track counted characters
            char ch = ' ';
            int mostCount = 0;

            for (int i = 0; i < s1.Length; i++)
            {
                if (counted[i] == false)
                {
                    int count = 1;

                    for (int j = i + 1; j < s1.Length; j++)
                    {
                        if (s1[i] == s1[j])
                        {
                            count++;
                            counted[j] = true;
                        }
                    }

                    if (count > mostCount)
                    {
                        mostCount = count;
                        ch = s1[i];
                    }
                }
            }

            Console.WriteLine("Most Frequent Character " + ch );
        }
    }

}

