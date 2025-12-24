using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level2
{
    internal class Grade
    {
        public static void Main(string[] args)
        {
            // Take number of students
            int students = int.Parse(Console.ReadLine());

            // Arrays to store data
            int[] physics = new int[students];
            int[] chemistry = new int[students];
            int[] maths = new int[students];
            double[] percentage = new double[students];
            char[] grade = new char[students];

            // Take marks input
            for (int i = 0; i < students; i++)
            {
                physics[i] = int.Parse(Console.ReadLine());
                chemistry[i] = int.Parse(Console.ReadLine());
                maths[i] = int.Parse(Console.ReadLine());

                // Validate marks
                if (physics[i] < 0 || chemistry[i] < 0 || maths[i] < 0)
                {
                    Console.WriteLine("Enter positive marks only");
                    i--;
                    continue;
                }
            }

            // Calculate percentage and grade
            for (int i = 0; i < students; i++)
            {
                percentage[i] = (physics[i] + chemistry[i] + maths[i]) / 3.0;

                if (percentage[i] >= 80)
                    grade[i] = 'A';
                else if (percentage[i] >= 70)
                    grade[i] = 'B';
                else if (percentage[i] >= 60)
                    grade[i] = 'C';
                else if (percentage[i] >= 50)
                    grade[i] = 'D';
                else if (percentage[i] >= 40)
                    grade[i] = 'E';
                else
                    grade[i] = 'R';
            }

            // Display result
            for (int i = 0; i < students; i++)
            {
                Console.WriteLine("Marks in Chemistry" + chemistry[i]);
                Console.WriteLine("Marks in Physics" + physics[i]);
                Console.WriteLine("Marks in Maths" + maths[i]);
                Console.WriteLine("Percentage is" + percentage[i]);
                Console.WriteLine("Grade is" + grade[i]);
            }
        }
    }
}
