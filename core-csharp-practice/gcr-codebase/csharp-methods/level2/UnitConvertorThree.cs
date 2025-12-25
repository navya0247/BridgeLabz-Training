using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.methods.level2
{
    internal class UnitConvertorThree
    {
        // Method to convert Fahrenheit to Celsius
        public static double ConvertFahrenheitToCelsius(double fahrenheit)
        {
            double fahrenheit2celsius = (fahrenheit - 32) * 5 / 9;
            return fahrenheit2celsius;
        }

        // Method to convert Celsius to Fahrenheit
        public static double ConvertCelsiusToFahrenheit(double celsius)
        {
            double celsius2fahrenheit = (celsius * 9 / 5) + 32;
            return celsius2fahrenheit;
        }

        // Method to convert Pounds to Kilograms
        public static double ConvertPoundsToKilograms(double pounds)
        {
            double pounds2kilograms = 0.453592;
            return pounds * pounds2kilograms;
        }

        // Method to convert Kilograms to Pounds
        public static double ConvertKilogramsToPounds(double kilograms)
        {
            double kilograms2pounds = 2.20462;
            return kilograms * kilograms2pounds;
        }

        // Method to convert Gallons to Liters
        public static double ConvertGallonsToLiters(double gallons)
        {
            double gallons2liters = 3.78541;
            return gallons * gallons2liters;
        }

        // Method to convert Liters to Gallons
        public static double ConvertLitersToGallons(double liters)
        {
            double liters2gallons = 0.264172;
            return liters * liters2gallons;
        }

        public static void Main(string[] args)
        {
            // take input from user
            double number = double.Parse(Console.ReadLine());

            Console.WriteLine("Fahrenheit to Celsius  " + ConvertFahrenheitToCelsius(number));
            Console.WriteLine("Celsius to Fahrenheit  " + ConvertCelsiusToFahrenheit(number));
            Console.WriteLine("Pounds to Kilograms  " + ConvertPoundsToKilograms(number));
            Console.WriteLine("Kilograms to Pounds  " + ConvertKilogramsToPounds(number));
            Console.WriteLine("Gallons to Liters  " + ConvertGallonsToLiters(number));
            Console.WriteLine("Liters to Gallons  " + ConvertLitersToGallons(number));
        }
    }
}
