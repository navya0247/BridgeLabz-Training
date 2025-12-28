using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.extraBuiltIn.level1
{
    internal class DateComparison
    {
        public static void Main(string[] args)
        {
            //take input from user
            DateTime date1 = DateTime.Parse(Console.ReadLine());
            DateTime date2 = DateTime.Parse(Console.ReadLine());

            // using built-in Compare method
            int result = DateTime.Compare(date1, date2);

            if (result < 0)
            {
                Console.WriteLine("First date is before second date");
            }
            else if (result > 0)
            {
                Console.WriteLine("First date is after second date");
            }
            else
            {
                Console.WriteLine("Both dates are the same");
            }
        }
    }

}
