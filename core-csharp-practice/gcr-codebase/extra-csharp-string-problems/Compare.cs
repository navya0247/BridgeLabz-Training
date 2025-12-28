using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.extraString
{
    internal class Compare
    {
        public static void Main(string[] args)
        {
            //take input from user
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();

            int i = 0;

            while (i < s1.Length && i < s2.Length)
            {
                if (s1[i] != s2[i])
                {
                    if (s1[i] < s2[i])
                        Console.WriteLine( s1 + " comes before " + s2 );
                    else
                        Console.WriteLine(  s2 + " comes before " + s1 );

                    return;
                }
                i++;
            }

            if (s1.Length == s2.Length)
            {
                Console.WriteLine("Both strings are same");
            }

            else if (s1.Length < s2.Length)
            {
                Console.WriteLine(s1 + " comes before " + s2);
            }
            else
            {
                Console.WriteLine(s2 + " comes before " + s1);
            }
        }
    }

}

