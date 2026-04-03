using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.extraBuiltIn.level1
{
    internal class DateFormat
    {   
        public static void Main(string[] args)
        {
            // get today's date
            DateTime today = DateTime.Now;

            //  using ToString() built-in
            Console.WriteLine(today.ToString("dd/MM/yyyy"));                // day/month/year
            Console.WriteLine(today.ToString("yyyy-MM-dd"));               // year-month-day
            Console.WriteLine(today.ToString("ddd, MMM dd, yyyy"));       // day, month, date, year
        }
    }

}

