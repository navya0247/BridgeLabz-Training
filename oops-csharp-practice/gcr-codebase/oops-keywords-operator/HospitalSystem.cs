using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.keywordsAndOperator
{
    internal class HospitalSystem
    {
            // static hospital name 
            public static string hospitalName;

            // static variable to count patients
            private static int patientCount = 0;

            // readonly patient id 
            public readonly int patientId;

            // instance variables
            public string name;
            public int age;
            public string ailment;

            // constructor using this keyword
            public HospitalSystem(int patientId, string name, int age, string ailment)
            {
                this.patientId = patientId;
                this.name = name;
                this.age = age;
                this.ailment = ailment;

                // increase patient count
                patientCount++;
            }

            // static method to get total patients
            public static void GetTotalPatients()
            {
                Console.WriteLine("Total Patients: " + patientCount);
            }

            // method to display patient details
            public void ShowDetails()
            {
                Console.WriteLine("Hospital Name : " + hospitalName);
                Console.WriteLine("Patient ID   : " + patientId);
                Console.WriteLine("Name         : " + name);
                Console.WriteLine("Age          : " + age);
                Console.WriteLine("Ailment      : " + ailment);
            }
        }

        class Program
        {
            public static void Main(string[] args)
            {
                // ask hospital name from user
                Console.WriteLine("Enter Hospital Name:");
            HospitalSystem.hospitalName = Console.ReadLine();

                Console.WriteLine();

                // take patient details
                Console.WriteLine("Enter Patient ID:");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Patient Name:");
                string pname = Console.ReadLine();

                Console.WriteLine("Enter Age:");
                int age = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Ailment:");
                string problem = Console.ReadLine();

            // create patient object
            HospitalSystem p1 = new HospitalSystem(id, pname, age, problem);

                Console.WriteLine();

                // check object using is operator
                if (p1 is HospitalSystem)
                {
                    Console.WriteLine("Valid Patient Object\n");
                    p1.ShowDetails();
                }
                else
                {
                    Console.WriteLine("Invalid Object");
                }

                Console.WriteLine();

            // show total patients
            HospitalSystem.GetTotalPatients();

                Console.ReadLine();
            }
        }
    }


