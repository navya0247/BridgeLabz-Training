using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BridgeLabzTraining.collections.regex
{
    internal class ValidateSocialSecurity
    {
       public static void Main(string[] args)
        {
            Console.Write("Enter SSN: ");
            string ssn = Console.ReadLine();

            string pattern = @"^\d{3}-\d{2}-\d{4}$";

            Console.WriteLine(
                Regex.IsMatch(ssn, pattern) ? "Valid SSN" : "Invalid SSN"
            );
        }
    }
}

