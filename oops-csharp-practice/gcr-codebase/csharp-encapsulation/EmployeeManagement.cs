using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.encapsulation
{
    // INTERFACE 
    interface IDepartment
    {
        void AssignDepartment(string deptName);
        string GetDepartmentDetails();
    }

    // ABSTRACT CLASS 
    abstract class Employee
    {
        // Encapsulation
        private int employeeId;
        private string name;
        private double baseSalary;

        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double BaseSalary
        {
            get { return baseSalary; }
            set { baseSalary = value; }
        }

        // Abstract method
        public abstract double CalculateSalary();

        // Concrete method
        public void DisplayDetails()
        {
            Console.WriteLine("Employee ID : " + EmployeeId);
            Console.WriteLine("Name        : " + Name);
            Console.WriteLine("Salary      : " + CalculateSalary());
        }
    }

    //  FULL TIME EMPLOYEE 
    class FullTimeEmployee : Employee, IDepartment
    {
        private string department;

        public override double CalculateSalary()
        {
            return BaseSalary; // fixed salary
        }

        public void AssignDepartment(string deptName)
        {
            department = deptName;
        }

        public string GetDepartmentDetails()
        {
            return department;
        }
    }

    // PART TIME EMPLOYEE 
    class PartTimeEmployee : Employee, IDepartment
    {
        public int WorkHours { get; set; }
        public double HourlyRate { get; set; }

        private string department;

        public override double CalculateSalary()
        {
            return WorkHours * HourlyRate;
        }

        public void AssignDepartment(string deptName)
        {
            department = deptName;
        }

        public string GetDepartmentDetails()
        {
            return department;
        }
    }

    // MAIN CLASS
    internal class EmployeeManagement
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number of employees: ");
            int count = int.Parse(Console.ReadLine());

            // Array of Employee reference
            Employee[] employees = new Employee[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("\nEnter employee type (1-Full Time, 2-Part Time): ");
                int type = int.Parse(Console.ReadLine());

                if (type == 1)
                {
                    FullTimeEmployee ft = new FullTimeEmployee();

                    Console.Write("Enter Employee ID: ");
                    ft.EmployeeId = int.Parse(Console.ReadLine());

                    Console.Write("Enter Name: ");
                    ft.Name = Console.ReadLine();

                    Console.Write("Enter Fixed Salary: ");
                    ft.BaseSalary = double.Parse(Console.ReadLine());

                    Console.Write("Enter Department: ");
                    ft.AssignDepartment(Console.ReadLine());

                    employees[i] = ft; // polymorphism
                }
                else if (type == 2)
                {
                    PartTimeEmployee pt = new PartTimeEmployee();

                    Console.Write("Enter Employee ID: ");
                    pt.EmployeeId = int.Parse(Console.ReadLine());

                    Console.Write("Enter Name: ");
                    pt.Name = Console.ReadLine();

                    Console.Write("Enter Work Hours: ");
                    pt.WorkHours = int.Parse(Console.ReadLine());

                    Console.Write("Enter Hourly Rate: ");
                    pt.HourlyRate = double.Parse(Console.ReadLine());

                    Console.Write("Enter Department: ");
                    pt.AssignDepartment(Console.ReadLine());

                    employees[i] = pt; // polymorphism
                }
                else
                {
                    Console.WriteLine("Invalid employee type");
                    i--; // repeat input
                }
            }

            // POLYMORPHISM 
            Console.WriteLine("\n Employee Details");

            for (int i = 0; i < employees.Length; i++)
            {
                employees[i].DisplayDetails();

                if (employees[i] is IDepartment dept)
                {
                    Console.WriteLine("Department  : " + dept.GetDepartmentDetails());
                }

            }
        }
    }
}
   
