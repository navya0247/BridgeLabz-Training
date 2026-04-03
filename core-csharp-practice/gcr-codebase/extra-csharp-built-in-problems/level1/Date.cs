using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.extraBuiltIn.level1
{
    internal class Date
    {      
       public static void Main(string[] args)
        {
            //take input from user
            Console.WriteLine("Enter date in format yyyy-mm-dd ");
            DateTime inputDate = DateTime.Parse(Console.ReadLine());

            // adding values
            DateTime updateDate = inputDate.AddDays(7);     
            updateDate = updateDate.AddMonths(1);          
            updateDate = updateDate.AddYears(2);          

            // subtract 3 weeks 
            updateDate = updateDate.AddDays(-21);

            Console.WriteLine("Final Date " + updateDate.ToString("yyyy-MM-dd"));
        }
    }

}

