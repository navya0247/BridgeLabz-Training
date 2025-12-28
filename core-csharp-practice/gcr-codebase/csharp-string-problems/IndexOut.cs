using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays
{
    internal class IndexOut
    {
        // method that generates IndexOutOfRangeException
        public static void GenerateException()
        {
            int[] num = { 10, 20, 30, 40, 50 };    // valid index

            Console.WriteLine(num[7]);          // invalid index
        }

        // method that handles the exception
        public static void ShowIndexOutOfRange()
        {
            try
            {
                GenerateException();
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Message " + e.Message);
            }
        }

        public static void Main(string[] args)
        {
            ShowIndexOutOfRange();
        }
    }
}
