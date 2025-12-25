using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.methods.level3
{
    internal class Calendar
    {
        // a) Method to get month name
        public static string GetMonthName(int month)
        {
            string[] monthNames =
            {
                "January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December"
            };

            return monthNames[month - 1];
        }

        // b) Method to check leap year
        public static bool IsLeapYear(int year)
        {
            return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
        }

        // b) Method to get number of days in a month
        public static int GetDaysInMonth(int month, int year)
        {
            int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (month == 2 && IsLeapYear(year))
                return 29;

            return days[month - 1];
        }

        // c) Method to get the first day of month using Gregorian calendar algorithm
        public static int GetFirstDay(int day, int month, int year)
        {
            int y0 = year - (14 - month) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = month + 12 * ((14 - month) / 12) - 2;
            int d0 = (day + x + (31 * m0) / 12) % 7;
            return d0; 
        }

        // d, e, f) Display the calendar
        public static void DisplayCalendar(int month, int year)
        {
            int totalDays = GetDaysInMonth(month, year);
            int startDay = GetFirstDay(1, month, year);

            Console.WriteLine(  GetMonthName(month) + " " + year + "\n");
            Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

            
            for (int i = 0; i < startDay; i++)
            {
                Console.Write("    ");
            }

            // print all days
            for (int day = 1; day <= totalDays; day++)
            {
                Console.Write("{0,3} ", day); 

                // move to next line after Saturday
                if ((day + startDay) % 7 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            //take input from user
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            DisplayCalendar(month, year);
        }
    }
}

