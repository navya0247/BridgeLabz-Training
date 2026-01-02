using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.keywordsAndOperator
{
    internal class UniversityManagement
    {
       
            // static variable shared by all students
            public static string universityName;

            // static variable to count students
            private static int studentCount = 0;

            // readonly roll number 
            public readonly int rollNo;

            // instance variables
            public string studentName;
            public char grade;

            // constructor using this keyword
            public UniversityManagement(int rollNo, string studentName, char grade)
            {
                this.rollNo = rollNo;
                this.studentName = studentName;
                this.grade = grade;

                // increase student count
                studentCount++;
            }

            // static method to display total students
            public static void DisplayTotalStudents()
            {
                Console.WriteLine("Total Students: " + studentCount);
            }

            // method to show student details
            public void ShowStudent()
            {
                Console.WriteLine("University Name : " + universityName);
                Console.WriteLine("Roll Number     : " + rollNo);
                Console.WriteLine("Student Name   : " + studentName);
                Console.WriteLine("Grade          : " + grade);
            }

            // method to update grade
            public void UpdateGrade(char newGrade)
            {
                grade = newGrade;
            }
        }

        class Program
        {
           public static void Main(string[] args)
            {
                // ask university name from user
                Console.WriteLine("Enter University Name:");
            UniversityManagement.universityName = Console.ReadLine();

                Console.WriteLine();

                // take student details
                Console.WriteLine("Enter Roll Number:");
                int roll = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Student Name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter Grade:");
                char grd = char.Parse(Console.ReadLine());

            // create student object
            UniversityManagement s1 = new UniversityManagement(roll, name, grd);

                Console.WriteLine();

                // check object using is operator
                if (s1 is UniversityManagement)
                {
                    Console.WriteLine("Valid Student Object\n");
                    s1.ShowStudent();

                    Console.WriteLine();
                    Console.WriteLine("Enter New Grade to Update:");
                    char newGrade = char.Parse(Console.ReadLine());

                    // update grade
                    s1.UpdateGrade(newGrade);

                    Console.WriteLine("\nUpdated Student Details:");
                    s1.ShowStudent();
                }
                else
                {
                    Console.WriteLine("Invalid Object");
                }

                Console.WriteLine();

            // display total students
            UniversityManagement.DisplayTotalStudents();

                Console.ReadLine();
            }
        }
    }

