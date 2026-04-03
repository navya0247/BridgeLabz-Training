using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BridgeLabzTraining.collections.regex
{
    internal class ExtractAllEmailAddressesfromText
    {
       public  static void Main(string[] args)
        {
            Console.WriteLine("Enter text:");
            string text = Console.ReadLine();

            // Regex pattern to find email addresses
            // + means one or more characters
            string pattern = @"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}";

            // Find all matches in the text
            MatchCollection matches = Regex.Matches(text, pattern);

            Console.WriteLine("\n Emails found:");

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value); // prints each email found
            }

            // If no email found
            if (matches.Count == 0)
            {
                Console.WriteLine("No email addresses found.");
            }
        }
    }

}

