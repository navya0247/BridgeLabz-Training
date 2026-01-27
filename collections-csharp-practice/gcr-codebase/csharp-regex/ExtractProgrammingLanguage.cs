using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BridgeLabzTraining.collections.regex
{
    internal class ExtractProgrammingLanguage
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();

            string pattern = @"\b(JavaScript|Java|Python|Go|C#)\b";
            MatchCollection matches = Regex.Matches(text, pattern);

            Console.WriteLine("Languages found:");
            foreach (Match m in matches)
            {
                Console.WriteLine(m.Value);
            }
        }
    }
}

