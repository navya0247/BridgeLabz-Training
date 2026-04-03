/*using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level2
{
    internal class BmiTwo
    {
        public static void Main(string[] args)
        {
            // Take input from user
            int number = int.Parse(Console.ReadLine());
            
            double[][] personData = new double[number][];
            string[] weightStatus = new string[number];

            // Initialize inner arrays
            for (int i = 0; i < number; i++)
            {
                personData[i] = new double[3];
            }

            // Take input for weight and height
            for (int i = 0; i < number; i++)
            {
               
                double weight = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                // Validate input
                if (weight <= 0 || height <= 0)
                {
                    Console.WriteLine("Enter positive values");
                    i--;
                    continue;
                }
                personData[i][0] = weight;
                personData[i][1] = height;
            }

            // Calculate BMI and weight status
            for (int i = 0; i < number; i++)
            {
                double weight = personData[i][0];
                double height = personData[i][1];

                double bmi = weight / (height * height);
                personData[i][2] = bmi;

                if (bmi <=18.5)
                {
                    weightStatus[i] = "Underweight";
                }
                else if (bmi >= 18.5 && bmi <= 24.9)
                {
                    weightStatus[i] = "Normal";
                }
                else if (bmi >= 25 && bmi <= 39.9)
                {
                    weightStatus[i] = "Overweight";
                }
                else
                {
                    weightStatus[i] = "Obese";
                }
            }

            // Display result
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("BMI: " + personData[i][2]);
                Console.WriteLine("Weight status is " + weightStatus[i]);

               
            }
        }
    }
}*/

