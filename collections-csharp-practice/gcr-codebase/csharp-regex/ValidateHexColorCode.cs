using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BridgeLabzTraining.collections.regex
{
    internal class ValidateHexColorCode
    {
       
        public static void Main(string[] args)
        {
            Console.Write("Enter hex color code: ");
            string input = Console.ReadLine();

            // Regex to validate hex color
 
            string pattern = @"^#[0-9A-Fa-f]{6}$";

            if (Regex.IsMatch(input, pattern))
            {
                Console.WriteLine(" Valid Hex Color Code");
            }
            else
            {
                Console.WriteLine(" Invalid Hex Color Code");
            }
        }
    }

}

