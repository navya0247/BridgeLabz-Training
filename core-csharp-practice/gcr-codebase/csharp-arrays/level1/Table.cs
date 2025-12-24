using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level1
{
    internal class Table
    {
        public static void Main(string[] args)
        {      
            //take input from user
            int number = int.Parse(Console.ReadLine());


            //Define array to store multiplication results
            int[] table = new int[10];

            //Store results in array
            for (int i = 1; i <= 10; i++)
            {
                table[i - 1] = number * i;
            }

            // Display multiplication table
            for (int i = 1; i <= 10; i++)
            {
             
                Console.WriteLine(number + " * " + i + " = " + table[i-1]);
            }
        }
    }
}
