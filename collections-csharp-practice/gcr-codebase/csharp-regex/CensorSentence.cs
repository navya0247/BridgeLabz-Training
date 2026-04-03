using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BridgeLabzTraining.collections.regex
{
    internal class CensorSentence
    {
       public static void Main(string[] args)
        {
            Console.Write("Enter sentence: ");
            string text = Console.ReadLine();

            string pattern = @"\b(damn|stupid)\b";
            string result = Regex.Replace(text, pattern, "****", RegexOptions.IgnoreCase);

            Console.WriteLine("Censored text:");
            Console.WriteLine(result);
        }
    }
}

