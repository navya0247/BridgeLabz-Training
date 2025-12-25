using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.methods.level2
{
    internal class UnitConvertor
    {
        //Method to convert Kilometers to Miles
        public static double ConvertKmToMiles(double km)
        {
            double kmToMiles = 0.621371;
            return km * kmToMiles;
        }

        // Method to convert Miles to Kilometers
        public static double ConvertMilesToKm(double miles)
        {
            double milesToKm = 1.60934;
            return miles * milesToKm;
        }

        // Method to convert Meters to Feet
        public static double ConvertMetersToFeet(double meters)
        {
            double metersToFeet = 3.28084;
            return meters * metersToFeet;
        }

        // Method to convert Feet to Meters
        public static double ConvertFeetToMeters(double feet)
        {
            double feetToMeters = 0.3048;
            return feet * feetToMeters;
        }

        public static void Main(string[] args)
        {
            //take input from user
            double number = double.Parse(Console.ReadLine());

            Console.WriteLine("Kilometers to Miles " + ConvertKmToMiles(number));
            Console.WriteLine("Miles to Kilometers " + ConvertMilesToKm(number));
            Console.WriteLine("Meters to Feet " + ConvertMetersToFeet(number));
            Console.WriteLine("Feet to Meters " + ConvertFeetToMeters(number));
        }
    }
}

