using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.objectModeling
{
    internal class UniversityManagement
    {
            // Student class 
            public class Student
            {
                public string studentName;
                public List<Course> courses;

                public Student(string studentName)
                {
                    this.studentName = studentName;
                    courses = new List<Course>();
                }

                // Student enrolls in a course 
                public void EnrollCourse(Course course)
                {
                    courses.Add(course);
                    course.AddStudent(this);
                    Console.WriteLine(studentName + " enrolled in " + course.courseName);
                }

                // View enrolled courses
                public void ViewCourses()
                {
                    Console.WriteLine("\nStudent: " + studentName);
                    Console.WriteLine("Enrolled Courses:");

                    for (int i = 0; i < courses.Count; i++)
                    {
                        Console.WriteLine("- " + courses[i].courseName);
                    }
                }
            }

            // Professor class 
            public class Professor
            {
                public string professorName;

                public Professor(string professorName)
                {
                    this.professorName = professorName;
                }

                // Assign professor to a course
                public void AssignProfessor(Course course)
                {
                    course.SetProfessor(this);
                    Console.WriteLine(professorName + " assigned to " + course.courseName);
                }
            }

            // Course class 
            public class Course
            {
                public string courseName;
                public Professor professor;
                public List<Student> students;

                public Course(string courseName)
                {
                    this.courseName = courseName;
                    students = new List<Student>();
                }

                // Add student to course (aggregation)
                public void AddStudent(Student student)
                {
                    students.Add(student);
                }

                // Set professor for course
                public void SetProfessor(Professor professor)
                {
                    this.professor = professor;
                }

                // Display course details
                public void DisplayCourse()
                {
                    Console.WriteLine("\nCourse: " + courseName);

                    if (professor != null)
                    {
                        Console.WriteLine("Professor: " + professor.professorName);
                    }

                    Console.WriteLine("Enrolled Students:");
                    for (int i = 0; i < students.Count; i++)
                    {
                        Console.WriteLine("- " + students[i].studentName);
                    }
                }
            }

            public static void Main(string[] args)
            {
                // Create students
                Student s1 = new Student("Navya");
                Student s2 = new Student("Vansh");

                // Create professors
                Professor p1 = new Professor("Dr.Yadav");
                Professor p2 = new Professor("Dr.Singhal");

                // Create courses
                Course c1 = new Course("Mathematics");
                Course c2 = new Course("Computer Science");

                // Assign professors to courses
                p1.AssignProfessor(c1);
                p2.AssignProfessor(c2);

                // Students enroll in courses
                s1.EnrollCourse(c1);
                s1.EnrollCourse(c2);

                s2.EnrollCourse(c2);

                // Students view their courses
                s1.ViewCourses();
                s2.ViewCourses();

                // Courses display details
                c1.DisplayCourse();
                c2.DisplayCourse();
            }
        }
    }



