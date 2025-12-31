using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.constructors
{
    internal class EmployeeRecord
    {
        
            public int employeeID;      // public
            protected string department; // protected
            private double salary;       // private

            public EmployeeRecord(int id, string dept, double sal)
            {
                employeeID = id;
                department = dept;
                salary = sal;
            }

            public void UpdateSalary(double newSalary)
            {
                salary = newSalary;
            }

            public double GetSalary()
            {
                return salary;
            }
        }

        internal class Manager : EmployeeRecord
    {
            public Manager(int id, string dept, double sal)
                : base(id, dept, sal)
            {
            }

            public static void Main(string[] args)
            {
                Manager m1 = new Manager(1001, "IT", 55000);

                Console.WriteLine("Employee ID: " + m1.employeeID);
                Console.WriteLine("Department : " + m1.department);
                Console.WriteLine("Salary: " + m1.GetSalary());

                m1.UpdateSalary(60000);
                Console.WriteLine("Updated Salary: " + m1.GetSalary());
            }
        }
    }


