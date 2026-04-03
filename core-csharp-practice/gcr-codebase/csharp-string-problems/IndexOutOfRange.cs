using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.strings
{
    internal class IndexOutOfRange
    {
        public static void ShowIndexOutOfRange()
        {
            //take input string
            string s1 = "navya";
            try                                                          //error throw
            {
                Console.WriteLine(s1[8]);
            }
            catch(IndexOutOfRangeException e)                     //catches null reference exception
            {
                Console.WriteLine("Message " + e.Message);
            }
        }

        public static void Main(string[] args)
        {
             //Method Call
            ShowIndexOutOfRange();
        }
    }
}
