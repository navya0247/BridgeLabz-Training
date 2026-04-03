using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.constructors
{
    internal class UniversityManagement
    {
            public int rollNumber;       // public
            protected string name;       // protected
            private double CGPA;         // private

            public UniversityManagement(int roll, string studentName, double cgpa)
            {
                rollNumber = roll;
                name = studentName;
                CGPA = cgpa;
            }

            // public methods to access private variable
            public double GetCGPA()
            {
                return CGPA;
            }

            public void SetCGPA(double newCGPA)
            {
                CGPA = newCGPA;
            }
        }

        internal class PostgraduateStudent : UniversityManagement
    {
            public PostgraduateStudent(int roll, string studentName, double cgpa)
                : base(roll, studentName, cgpa)
            {
            }

            public static void Main(string[] args)
            {
                PostgraduateStudent pgs = new PostgraduateStudent(101, "Navya", 8.5);

                Console.WriteLine("Roll Number: " + pgs.rollNumber);
                Console.WriteLine("Name (Protected Accessible Here): " + pgs.name);
                Console.WriteLine("CGPA: " + pgs.GetCGPA());

                pgs.SetCGPA(8.1);
                Console.WriteLine("Updated CGPA: " + pgs.GetCGPA());
            }
        }
    }


