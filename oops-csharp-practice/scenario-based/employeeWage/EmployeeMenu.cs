using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenerioBased.employeeWage
{
    internal class EmployeeMenu
    {


        private IEmployee employeeUtility;

        public EmployeeMenu()
        {
            employeeUtility = new EmployeeUtilityImpl();
            EmployeeChoice();
        }

        public void EmployeeChoice()
        {
            Console.WriteLine("1. Calculate Employee Wage");
            Console.Write("Enter your choice: ");

           int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    employeeUtility.AddEmployee();
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}