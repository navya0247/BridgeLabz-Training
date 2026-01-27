using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BridgeLabzTraining.collections.regex
{
    internal class ValidateUsername
    {
       public static void Main(string[] args)
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            // Regex pattern for valid username
            string pattern = @"^[A-Za-z][A-Za-z0-9_]{4,14}$";

            if (Regex.IsMatch(username, pattern))
            {
                Console.WriteLine(" Valid Username");
            }
            else
            {
                Console.WriteLine(" Invalid Username");
            }
        }
    }

}

