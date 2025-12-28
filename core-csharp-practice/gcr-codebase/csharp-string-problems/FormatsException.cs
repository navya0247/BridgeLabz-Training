using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.strings
{
    internal class FormatsException
    {
        // method that generates FormatException
        public static void GeneratFormatException()
        {
            string s1 = "abc";                    // non-numeric string
            int num = int.Parse(s1);             // this will throw FormatException
            Console.WriteLine(num);
        }

        // method that handles the exception
        public static void ShowFormatException()
        {
            try
            {
                GeneratFormatException();
            }
            catch (FormatException e)
            {
                Console.WriteLine("Message " + e.Message);
            }
        }

        public static void Main(string[] args)
        {
            //Method Call
            ShowFormatException();
        }
    }
}
