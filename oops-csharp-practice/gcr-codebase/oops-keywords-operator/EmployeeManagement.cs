using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.keywordsAndOperator
{ 
   internal class EmployeeManagement
    {
        // static company name
        public static string companyTitle;

        // static variable to count employees
        private static int staffCount = 0;

        // readonly employee id
        public readonly int empId;

        public string empName;
        public string empRole;

        // constructor using this keyword
        public EmployeeManagement(int empId, string empName, string empRole)
        {
            this.empId = empId;
            this.empName = empName;
            this.empRole = empRole;

            // increase count when object is created
            staffCount++;
        }

        // static method to show total employees
        public static void DisplayTotalEmployees()
        {
            Console.WriteLine("Total Employees: " + staffCount);
        }

        // display employee information
        public void ShowDetails()
        {
            Console.WriteLine("Company Name  : " + companyTitle);
            Console.WriteLine("Employee ID   : " + empId);
            Console.WriteLine("Employee Name : " + empName);
            Console.WriteLine("Designation   : " + empRole);
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            // ask company name from user
            Console.WriteLine("Enter Company Name:");
            EmployeeManagement.companyTitle = Console.ReadLine();

            Console.WriteLine();

            // take employee id
            Console.WriteLine("Enter Employee ID:");
            int id = int.Parse(Console.ReadLine());

            // take employee name
            Console.WriteLine("Enter Employee Name:");
            string name = Console.ReadLine();

            // take designation
            Console.WriteLine("Enter Designation:");
            string role = Console.ReadLine();

            // create employee object
            EmployeeManagement s1 = new EmployeeManagement(id, name, role);

            Console.WriteLine();

            // check object using is operator
            if (s1 is EmployeeManagement)
            {
                Console.WriteLine("Valid Staff Object\n");
                s1.ShowDetails();
            }
            else
            {
                Console.WriteLine("Invalid Object");
            }

            Console.WriteLine();

            // show total employees
            EmployeeManagement.DisplayTotalEmployees();

            Console.ReadLine();
        }
    }
}
