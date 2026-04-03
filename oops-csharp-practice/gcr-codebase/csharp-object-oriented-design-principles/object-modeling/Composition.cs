using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.objectModeling
{
    internal class Composition
    {
            // Company class
            class Company
            {
                public string companyName;
                public List<Department> departments;

                // Constructor
                public Company(string companyName)
                {
                    this.companyName = companyName;
                    departments = new List<Department>();
                }

                // Add department to company
                public void AddDepartment(string deptName)
                {
                    departments.Add(new Department(deptName));
                }

                // Display company details
                public void DisplayCompany()
                {
                    Console.WriteLine("Company Name: " + companyName);

                    for (int i = 0; i < departments.Count; i++)
                    {
                        departments[i].DisplayDepartment();
                    }
                }
            }

            // Department class 
            class Department
            {
                public string departmentName;
                public List<Employee> employees;

                // Constructor
                public Department(string departmentName)
                {
                    this.departmentName = departmentName;
                    employees = new List<Employee>();
                }

                // Add employee to department
                public void AddEmployee(string empName)
                {
                    employees.Add(new Employee(empName));
                }

                // Display department details
                public void DisplayDepartment()
                {
                    Console.WriteLine("\nDepartment: " + departmentName);

                    for (int i = 0; i < employees.Count; i++)
                    {
                        employees[i].DisplayEmployee();
                    }
                }
            }

            // Employee class 
            class Employee
            {
                public string employeeName;

                // Constructor
                public Employee(string employeeName)
                {
                    this.employeeName = employeeName;
                }

                // Display employee details
                public void DisplayEmployee()
                {
                    Console.WriteLine("Employee: " + employeeName);
                }
            }

            // Main method
            public static void Main(string[] args)
            {
                // Create Company object
                Company company = new Company("Tech Solutions");

                // Add departments
                company.AddDepartment("HR");
                company.AddDepartment("Development");

                // Add employees to departments
                company.departments[0].AddEmployee("Rahul");
                company.departments[0].AddEmployee("Anita");

                company.departments[1].AddEmployee("Suresh");
                company.departments[1].AddEmployee("Kiran");

                // Display company structure
                company.DisplayCompany();

            }
        }
    }


