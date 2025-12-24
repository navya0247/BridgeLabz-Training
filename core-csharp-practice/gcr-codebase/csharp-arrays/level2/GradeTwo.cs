using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level2
{
    internal class GradeTwo
    {
        public static void Main(string[] args)
        {
            // Take number of students
            int students = int.Parse(Console.ReadLine());

            // 2D array to store marks
            int[,] marks = new int[students, 3];

            // Arrays for percentage and grade
            double[] percentage = new double[students];
            char[] grade = new char[students];

            // Take marks input
            for (int i = 0; i < students; i++)
            {
                marks[i, 0] = int.Parse(Console.ReadLine()); // Physics
                marks[i, 1] = int.Parse(Console.ReadLine()); // Chemistry
                marks[i, 2] = int.Parse(Console.ReadLine()); // Maths

                // Validate marks
                if (marks[i, 0] < 0 || marks[i, 1] < 0 || marks[i, 2] < 0)
                {
                    Console.WriteLine("Enter positive marks only");
                    i--;
                    continue;
                }
            }

            // Calculate percentage and grade
            for (int i = 0; i < students; i++)
            {
                percentage[i] =
                    (marks[i, 0] + marks[i, 1] + marks[i, 2]) / 3.0;

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
                Console.WriteLine("Marks in Physics: " + marks[i, 0]);
                Console.WriteLine("Marks in Chemistry: " + marks[i, 1]);
                Console.WriteLine("Marks in Maths: " + marks[i, 2]);
                Console.WriteLine("Percentage is: " + percentage[i]);
                Console.WriteLine("Grade is: " + grade[i]);
            }
        }
    }
}
