using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BridgeLabzTraining.collections.regex
{
    internal class FindRepeatingWords
    {
       public static void Main(string[] args)
        {
            Console.Write("Enter sentence: ");
            string text = Console.ReadLine();

            string pattern = @"\b(\w+)\s+\1\b";
            MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);

            Console.WriteLine("Repeating words:");
            foreach (Match m in matches)
            {
                Console.WriteLine(m.Groups[1].Value);
            }
        }
    }
}

