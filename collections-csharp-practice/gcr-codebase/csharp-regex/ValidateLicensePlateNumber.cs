using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BridgeLabzTraining.collections.regex
{
    internal class ValidateLicensePlateNumber
    {
      
       public static void Main(string[] args)
        {
            Console.Write("Enter license plate: ");
            string plate = Console.ReadLine();
            string pattern = @"^[A-Z]{2}[0-9]{4}$";

            if (Regex.IsMatch(plate, pattern))
                Console.WriteLine(" Valid License Plate");
            else
                Console.WriteLine(" Invalid License Plate");
        }
    }

}

