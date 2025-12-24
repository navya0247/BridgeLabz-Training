using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level1
{
    internal class TableTwo
    {
        public static void Main(string[] args)
        {
            //take input from user
            int number = int.Parse(Console.ReadLine());

            int[] arr = new int[10];


            // Store multiplication results from 1 to 10
            for (int i = 1; i <arr.Length; i++)
            {
                arr[i - 1] = number * i;
            }

            // Display table from 6 to 9
            for (int i = 6; i <= 9; i++)
            {
                Console.WriteLine(number+" * "+ i + " = "+ arr[i - 1]);
            }

        }
    }
}
