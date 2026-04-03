using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BridgeLabzTraining.collections.regex
{
    internal class ValidateCreditCard
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter card number: ");
            string card = Console.ReadLine();

            string pattern = @"^(4\d{15}|5\d{15})$";

            Console.WriteLine(
                Regex.IsMatch(card, pattern) ? "Valid Card" : "Invalid Card"
            );
        }
    }
}

