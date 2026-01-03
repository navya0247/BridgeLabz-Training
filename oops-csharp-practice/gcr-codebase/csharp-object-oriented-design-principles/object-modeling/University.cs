using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.objectModeling
{
    internal class University
    {
        //  Faculty class (Aggregation)
        public class Faculty
        {
            public string facultyName;

            public Faculty(string facultyName)
            {
                this.facultyName = facultyName;
            }

            public void DisplayFaculty()
            {
                Console.WriteLine("Faculty Name: " + facultyName);
            }
        }

        //  Department class (Composition) 
        public class Department
        {
            public string departmentName;

            public Department(string departmentName)
            {
                this.departmentName = departmentName;
            }

            public void DisplayDepartment()
            {
                Console.WriteLine("Department: " + departmentName);
            }
        }

        public string universityName;
        public List<Department> departments;   // composition
        public List<Faculty> faculties;        // aggregation

        // Constructor
        public University(string universityName)
        {
            this.universityName = universityName;
            departments = new List<Department>();
            faculties = new List<Faculty>();
        }

        // Add department (composition)
        public void AddDepartment(string deptName)
        {
            departments.Add(new Department(deptName));
        }

        // Add faculty (aggregation)
        public void AddFaculty(Faculty faculty)
        {
            faculties.Add(faculty);
        }

        // Display university details
        public void DisplayUniversity()
        {
            Console.WriteLine("\nUniversity Name: " + universityName);

            Console.WriteLine("\nDepartments:");
            for (int i = 0; i < departments.Count; i++)
            {
                departments[i].DisplayDepartment();
            }

            Console.WriteLine("\nFaculties:");
            for (int i = 0; i < faculties.Count; i++)
            {
                faculties[i].DisplayFaculty();
            }
        }

        public static void Main(string[] args)
        {
            // Faculty objects (independent)
            Faculty f1 = new Faculty("Dr. Sharma");
            Faculty f2 = new Faculty("Dr. Mehta");

            // Create university
            University uni = new University("GLA University");

            // Add departments (composition)
            uni.AddDepartment("Computer Science");
            uni.AddDepartment("Mechanical Engineering");

            // Add faculty (aggregation)
            uni.AddFaculty(f1);
            uni.AddFaculty(f2);

            // Display university structure
            uni.DisplayUniversity();

            
        }
    }
}
