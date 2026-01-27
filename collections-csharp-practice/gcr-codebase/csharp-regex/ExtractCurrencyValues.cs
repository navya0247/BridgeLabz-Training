using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BridgeLabzTraining.collections.regex
{
    internal class ExtractCurrencyValues
    {
       public static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();

            string pattern = @"\$?\s?\d+\.\d{2}";
            MatchCollection matches = Regex.Matches(text, pattern);

            Console.WriteLine("Currency values:");
            foreach (Match m in matches)   
            
            {
                Console.WriteLine(m.Value.Trim());
            }
        }
    }
}

