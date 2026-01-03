using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.objectModeling
{
    internal class School
    {
            public class Course
            {
                public string courseName;
                public List<Student> students;

                public Course(string courseName)
                {
                    this.courseName = courseName;
                    students = new List<Student>();
                }

                // Add student to course (association)
                public void AddStudent(Student student)
                {
                    students.Add(student);
                }

                // Show students in this course
                public void ShowStudents()
                {
                    Console.WriteLine("\nCourse: " + courseName);
                    Console.WriteLine("Enrolled Students:");

                    for (int i = 0; i < students.Count; i++)
                    {
                        Console.WriteLine("- " + students[i].name);
                    }
                }
            }

            public class Student
            {
                public string name;
                public List<Course> courses;

                public Student(string name)
                {
                    this.name = name;
                    courses = new List<Course>();
                }

                // Enroll student in a course (association)
                public void EnrollCourse(Course course)
                {
                    courses.Add(course);
                    course.AddStudent(this);
                }

                // View courses of student
                public void ViewCourses()
                {
                    Console.WriteLine("\nStudent: " + name);
                    Console.WriteLine("Enrolled Courses:");

                    for (int i = 0; i < courses.Count; i++)
                    {
                        Console.WriteLine("- " + courses[i].courseName);
                    }
                }
            }

            //  School (aggregation) 
            public string schoolName;
            public List<Student> students;

            public School(string schoolName)
            {
                this.schoolName = schoolName;
                students = new List<Student>();
            }

            // Add student to school
            public void AddStudent(Student student)
            {
                students.Add(student);
            }

            public static void Main(string[] args)
            {
                // Create school
                School school = new School("St. Andrews School");

                // Create students
                Student s1 = new Student("Rahul");
                Student s2 = new Student("Anita");

                // Add students to school (aggregation)
                school.AddStudent(s1);
                school.AddStudent(s2);

                // Create courses
                Course c1 = new Course("Math");
                Course c2 = new Course("Science");

                // Enroll students in courses (association)
                s1.EnrollCourse(c1);
                s1.EnrollCourse(c2);

                s2.EnrollCourse(c2);

                // Students view their courses
                s1.ViewCourses();
                s2.ViewCourses();

                // Courses show enrolled students
                c1.ShowStudents();
                c2.ShowStudents();
            }
        }
    }


