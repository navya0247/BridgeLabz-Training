using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenerioBased.employeeWage
{
    internal class EmployeeMain
    {
        private EmployeeMenu employeeMenu;


        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program\n");
            new EmployeeMenu();
            Console.WriteLine("\nThank You");
        }
    }
}