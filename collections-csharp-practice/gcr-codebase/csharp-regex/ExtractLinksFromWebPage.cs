using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BridgeLabzTraining.collections.regex
{
    internal class ExtractLinksFromWebPage
    {
           public static void Main(string[] args)
            {
                Console.Write("Enter text with links: ");
                string text = Console.ReadLine();

                string pattern = @"https?://\S+";
                MatchCollection matches = Regex.Matches(text, pattern);

                Console.WriteLine("Links found:");
                foreach (Match m in matches)
                {
                    Console.WriteLine(m.Value);
                }
            }
        }
    }

