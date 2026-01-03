using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.inheritance
{
    internal class EmployeeSystem
    {
        
            public string name;
            public int id;
            public double salary;

            // Constructor to initialize common details
            public EmployeeSystem(string name, int id, double salary)
            {
                this.name = name;
                this.id = id;
                this.salary = salary;
            }

            // Method to display employee details
            public virtual void DisplayDetails()
            {
                Console.WriteLine("Name   : " + name);
                Console.WriteLine("Id     : " + id);
                Console.WriteLine("Salary : " + salary);
            }
        }

        // Manager class
        class Manager : EmployeeSystem
    {
            public int teamSize;

            public Manager(string name, int id, double salary, int teamSize)
                : base(name, id, salary)
            {
                this.teamSize = teamSize;
            }

            public override void DisplayDetails()
            {
                Console.WriteLine("\nEmployee Type: Manager");
                base.DisplayDetails();
                Console.WriteLine("Team Size: " + teamSize);
            }
        }

        // Developer class
        class Developer : EmployeeSystem
    {
            public string language;

            public Developer(string name, int id, double salary, string language)
                : base(name, id, salary)
            {
                this.language = language;
            }

            public override void DisplayDetails()
            {
                Console.WriteLine("\nEmployee Type: Developer");
                base.DisplayDetails();
                Console.WriteLine("Programming Language: " + language);
            }
        }

        // Intern class
        class Intern : EmployeeSystem
    {
            public string duration;

            public Intern(string name, int id, double salary, string duration)
                : base(name, id, salary)
            {
                this.duration = duration;
            }

            public override void DisplayDetails()
            {
                Console.WriteLine("\nEmployee Type: Intern");
                base.DisplayDetails();
                Console.WriteLine("Internship Duration: " + duration);
            }
        }

        class Program
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("Enter Employee Type (Manager / Developer / Intern):");
                string type = Console.ReadLine();

                Console.WriteLine("Enter Name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter Id:");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Salary:");
                double salary = double.Parse(Console.ReadLine());

            EmployeeSystem emp; // parent reference

                if (type == "Manager")
                {
                    Console.WriteLine("Enter Team Size:");
                    int teamSize = int.Parse(Console.ReadLine());

                    emp = new Manager(name, id, salary, teamSize);
                }
                else if (type == "Developer")
                {
                    Console.WriteLine("Enter Programming Language:");
                    string lang = Console.ReadLine();

                    emp = new Developer(name, id, salary, lang);
                }
                else if (type == "Intern")
                {
                    Console.WriteLine("Enter Internship Duration:");
                    string duration = Console.ReadLine();

                    emp = new Intern(name, id, salary, duration);
                }
                else
                {
                    Console.WriteLine("Invalid Employee Type");
                    return;
                }

                // Polymorphism
                emp.DisplayDetails();
            }
        }
    }


