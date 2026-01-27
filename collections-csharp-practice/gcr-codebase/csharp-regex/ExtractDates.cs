using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BridgeLabzTraining.collections.regex
{
    internal class ExtractDates
    {        
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter text:");
            string text = Console.ReadLine();

            string pattern = @"\b(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/\d{4}\b";

            MatchCollection matches = Regex.Matches(text, pattern);

            Console.WriteLine("\n Dates found:");

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }

            if (matches.Count == 0)
            {
                Console.WriteLine("No dates found.");
            }
        }
    }

}

