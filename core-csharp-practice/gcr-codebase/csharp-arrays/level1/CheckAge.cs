using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level1
{
    internal class CheckAge
    {
        public static void Main(string[] args)
        {

            // Take input for 10 students
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            // Check voting eligibility
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    Console.WriteLine("Invalid age");

                }
                else if (arr[i] >= 18)
                {
                    Console.WriteLine("The student with the age " + arr[i] + " can vote");
                }
                else
                {
                    Console.WriteLine("The student with the age " + arr[i] + " cannot vote");
                }
            }

        }
    }
}

    




