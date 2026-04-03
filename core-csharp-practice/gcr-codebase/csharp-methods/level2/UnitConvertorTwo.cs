using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.methods.level2
{
    internal class UnitConvertorTwo
    {
        // Method to convert Yards to Feet
        public static double ConvertYardsToFeet(double yards)
        {
            double yardsToFeet = 3;
            return yards * yardsToFeet;
        }

        // Method to convert Feet to Yards
        public static double ConvertFeetToYards(double feet)
        {
            double feetToYards = 0.333333;
            return feet * feetToYards;
        }

        // Method to convert Meters to Inches
        public static double ConvertMetersToInches(double meters)
        {
            double metersToInches = 39.3701;
            return meters * metersToInches;
        }

        // Method to convert Inches to Meters
        public static double ConvertInchesToMeters(double inches)
        {
            double inchesToMeters = 0.0254;
            return inches * inchesToMeters;
        }

        // Method to convert Inches to Centimeters
        public static double ConvertInchesToCentimeters(double inches)
        {
            double inchesToCm = 2.54;
            return inches * inchesToCm;
        }

        public static void Main(string[] args)
        {
            // take input from user
            double number = double.Parse(Console.ReadLine());

            Console.WriteLine("Yards to Feet  " + ConvertYardsToFeet(number));
            Console.WriteLine("Feet to Yards  " + ConvertFeetToYards(number));
            Console.WriteLine("Meters to Inches  " + ConvertMetersToInches(number));
            Console.WriteLine("Inches to Meters  " + ConvertInchesToMeters(number));
            Console.WriteLine("Inches to Centimeters  " + ConvertInchesToCentimeters(number));
        }
    }
}
