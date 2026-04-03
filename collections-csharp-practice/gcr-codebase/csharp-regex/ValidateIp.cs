using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BridgeLabzTraining.collections.regex
{
    internal class ValidateIp
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter IP address: ");
            string ip = Console.ReadLine();

            string pattern =
                @"^((25[0-5]|2[0-4]\d|[01]?\d\d?)\.){3}" +
                @"(25[0-5]|2[0-4]\d|[01]?\d\d?)$";

            Console.WriteLine(
                Regex.IsMatch(ip, pattern) ? "Valid IP" : "Invalid IP"
            );
        }
    }
}

