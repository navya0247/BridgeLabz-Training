using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.constructors
{
    internal class OnlineCourse
    {
            public string courseName;   // instance variable
            public int duration;        // instance variable
            public double fee;          // instance variable

            public static string instituteName = "BridgeLabz"; // class variable

            public OnlineCourse(string name, int time, double cost)
            {
                courseName = name;
                duration = time;
                fee = cost;
            }

            // instance method
            public void DisplayCourseDetails()
            {
                Console.WriteLine("Course Name: " + courseName);
                Console.WriteLine("Duration: " + duration + " months");
                Console.WriteLine("Fee: " + fee);
                Console.WriteLine("Institute: " + instituteName);
            }

            // class method
            public static void UpdateInstituteName(string newName)
            {
                instituteName = newName;
            }

            public static void Main(string[] args)
            {
                OnlineCourse c1 = new OnlineCourse("Java Fullstack", 6, 25000);
            OnlineCourse c2 = new OnlineCourse("Python Backend", 4, 20000);

                c1.DisplayCourseDetails();
                c2.DisplayCourseDetails();

            OnlineCourse.UpdateInstituteName("Tech Academy");

                c1.DisplayCourseDetails();
                c2.DisplayCourseDetails();
            }
        }
    }


