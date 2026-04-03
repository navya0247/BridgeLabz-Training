using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.extraString
{
    internal class SubstringOcc
    {
         public static void Main(string[] args)
        {    
            //take Input from user
            string s1 = Console.ReadLine();
            string sub = Console.ReadLine();

            int count = 0;

            for (int i = 0; i <= s1.Length - sub.Length; i++)
            {
                int j;
                for ( j = 0; j < sub.Length; j++)
                {
                    if (s1[i + j] != sub[j])
                    {
                        break;
                    }
                }

                if (j == sub.Length)
                {
                    count++;
                }
            }

            //Display Result
            Console.WriteLine("Occurrences " + count);
        }
    }

}

