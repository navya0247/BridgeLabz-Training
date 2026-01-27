using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BridgeLabzTraining.collections.regex
{
    internal class ExtractCapitalizedWordsfromSentence
    {
       
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence:");
            string text = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]*\b";

            MatchCollection matches = Regex.Matches(text, pattern);

            Console.WriteLine("\n Capitalized words found:");

            foreach (Match match in matches)
            {
                if (match.Value != "The")
                    Console.WriteLine(match.Value);
            }

            if (matches.Count == 0)
                Console.WriteLine("No capitalized words found.");
        }
    }

}

