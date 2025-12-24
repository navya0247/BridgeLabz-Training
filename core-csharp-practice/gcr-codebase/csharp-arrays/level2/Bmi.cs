using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level2
{
    internal class Bmi
    {
        public static void Main(string[] args)
        {    
            //take input from user
            int person = int.Parse(Console.ReadLine());

            double[] weight = new double[person];
            double[] height = new double[person];
            string[] weightStatus = new string[person];
            double[] bmi = new double[person];

            //Take input for weight and height
            for (int i = 0; i < person; i++)
            {
                weight[i] = double.Parse(Console.ReadLine());
                height[i] = double.Parse(Console.ReadLine());

            }

            // Calculate BMI and status
            for (int i = 0; i < person; i++)
            {
                bmi[i] = weight[i] / (height[i] * height[i]);

                if (bmi[i] <= 18.5)
                {
                    weightStatus[i] = "UnderWeight";
                }
                else if (bmi[i]>=18.5 && bmi[i]<=24.9)
                {
                    weightStatus[i] = "Normal";
                }
                else if (bmi[i]>=25.0 && bmi[i] <= 39.9)
                {
                    weightStatus[i] = "Overweight";
                }
                else
                {
                    weightStatus[i] = "Obese";
                }
            }

            // Display result
            for (int i = 0; i < person; i++)
            {
                Console.WriteLine("BMI is " + bmi[i]);
                Console.WriteLine("Weight status is " + weightStatus[i]);
            }

            
        }
    }
}
