using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.methods.level2
{
    internal class LeapYea
    {

        // Method to check for Leap Year
        public static bool CalculateYear(int year)
        {
            if (year < 1582)
            {
                return false;
            }

            if((year%400==0)||(year%4==0 && year % 100 != 0))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

      
        public static void Main(String[] args)
        {

            //take year from user
            int year = int.Parse(Console.ReadLine());

            //check wheather the year is valid
            if (year < 1582)
            {
                Console.WriteLine("Year must be 1582 or later");
            }

            else
            {
                //Method Call
                bool leap = CalculateYear(year);
                if (leap)
                {
                    Console.WriteLine("Year is a Leap Year");
                }
                else
                {
                    Console.WriteLine("Year is not a Leap Year");

                }
            }
        }
    }
}

