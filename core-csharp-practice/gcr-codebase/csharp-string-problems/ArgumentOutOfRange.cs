using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.strings
{
    internal class ArgumentOutOfRange
    {
        // method that generates ArgumentOutOfRangeException
        public static void ShowArgumentOutOfRange()
        {
            string s1 = "navyayadav";

            try
            { 
              Console.WriteLine(s1.Substring(15, 3));  // invalid substring range: start index is bigger than string length
            }

            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Message " + e.Message);
            }
        }

        public static void Main(string[] args)
        {
            //Method Call
            ShowArgumentOutOfRange();
        }
    }
}

