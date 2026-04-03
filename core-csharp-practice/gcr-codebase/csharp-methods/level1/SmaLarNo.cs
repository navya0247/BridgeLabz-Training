using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.methods.level1
{
    internal class SmaLarNo
    {
        //Method to find smallest and largest
        public static int[] FindSmallestAndLargest(int num1,int num2,int num3)
        {
            int smallest = num1;
            int largest = num1;
            if (num2 < smallest)
            {
                smallest = num2;
            }
            if (num3 < smallest)
            {
                smallest = num3;
            }
            if (num2 > largest)
            {
                largest = num2;
            }
            if (num3 > largest)
            {
                largest = num3;
            }
            return new int[] { smallest, largest };         //store the smallest and largest in an array
        }
        public static void Main(string[] args)
        {
            //Take input from user
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            //Method Call
            int[] result = FindSmallestAndLargest(num1, num2, num3);

            Console.WriteLine("Smallest number is " + result[0]);
            Console.WriteLine("Largest number is " + result[1]);


        }
    }
}
