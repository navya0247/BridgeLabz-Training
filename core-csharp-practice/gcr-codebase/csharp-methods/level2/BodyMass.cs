using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.methods.level2
{
    internal class BodyMass
    {
        // Method to calculate BMI and store into the array
        public static void CalculateBMI(double[,] data)
        {
            for (int i = 0; i < 10; i++)
            {
                double weight = data[i, 0];   
                double heightCm = data[i, 1]; 
                double heightM = heightCm / 100.0; 

                double bmi = weight / (heightM * heightM); // BMI formula
                data[i, 2] = bmi;          // store BMI
            }
        }

        // Method to determine BMI Status 
        public static string[] GetBMIStatus(double[,] data)
        {
            string[] status = new string[10];

            for (int i = 0; i < 10; i++)
            {
                double bmi = data[i, 2];

                if (bmi <= 18.4)
                    status[i] = "Underweight";
                else if (bmi >= 18.5 && bmi <= 24.9)
                    status[i] = "Normal";
                else if (bmi >= 25.0 && bmi <= 39.9)
                    status[i] = "Overweight";
                else
                    status[i] = "Obese";
            }

            return status;
        }

        public static void Main(string[] args)
        {
            // Create 2D array
            double[,] persons = new double[10, 3];

            // Take input from user
            for (int i = 0; i < 10; i++)
            {   
                persons[i, 0] = double.Parse(Console.ReadLine());
                persons[i, 1] = double.Parse(Console.ReadLine());
            }

            // Calculate BMI
            CalculateBMI(persons);

            // Get BMI status
            string[] bmiStatus = GetBMIStatus(persons);

            // Display values
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(persons[i, 0]);
                Console.WriteLine( persons[i, 1]);
                Console.WriteLine(persons[i, 2]);
                Console.WriteLine(bmiStatus[i]);
                
            }
        }
    }
}
