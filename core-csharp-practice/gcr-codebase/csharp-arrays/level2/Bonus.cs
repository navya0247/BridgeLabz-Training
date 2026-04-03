using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level2
{
    internal class Bonus
    {
        public static void Main(string[] args)
        {
            // Arrays for salary and years of service
            double[] salary = new double[10];
            double[] yearsOfService = new double[10];

            // Arrays for bonus and new salary
            double[] bonus = new double[10];
            double[] newSalary = new double[10];

            double totalBonus = 0;
            double totalOldSalary = 0;
            double totalNewSalary = 0;

            // Take input for 10 employees
            for (int i = 0; i < 10; i++)
            { 
                salary[i] = double.Parse(Console.ReadLine());
                yearsOfService[i] = double.Parse(Console.ReadLine());
            }

            // Calculate bonus and new salary
            for (int i = 0; i < 10; i++)
            {
                if (yearsOfService[i] > 5)
                {
                    bonus[i] = salary[i] * 0.05;   // 5% bonus
                }
                else
                {
                    bonus[i] = salary[i] * 0.02;   // 2% bonus
                }

                newSalary[i] = salary[i] + bonus[i];

                totalBonus += bonus[i];
                totalOldSalary += salary[i];
                totalNewSalary += newSalary[i];
            }

       
            //print results
            Console.WriteLine("Total Old Salary " + totalOldSalary);
            Console.WriteLine("Total Bonus Paid by Zara " + totalBonus);
            Console.WriteLine("Total New Salary " + totalNewSalary);
        }
    }
}
