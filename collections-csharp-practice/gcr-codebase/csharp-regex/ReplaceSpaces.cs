using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BridgeLabzTraining.collections.regex
{
    internal class ReplaceSpaces
    {
           public static void Main(string[] args)
            {
                Console.Write("Enter text: ");
                string text = Console.ReadLine();

                string result = Regex.Replace(text, @"\s+", " ");

                Console.WriteLine("Result:");
                Console.WriteLine(result);
            }
        }
    }

