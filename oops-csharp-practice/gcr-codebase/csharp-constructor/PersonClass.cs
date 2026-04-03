using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.constructors
{
    internal class PersonClass
    {
            public string Name;
            public int Age;

            // Parameterized constructor
            public PersonClass(string name, int age)
            {
                Name = name;
                Age = age;
            }

            // Copy constructor
            public PersonClass(PersonClass other)
            {
                Name = other.Name;
                Age = other.Age;
            }

            public static void Main(string[] args)
            {
                // Using parameterized constructor
                PersonClass person1 = new PersonClass("Navya", 22);
                Console.WriteLine("Name: " + person1.Name);
                Console.WriteLine("Age: " + person1.Age);


                // Using copy constructor
                PersonClass person2 = new PersonClass(person1);
                Console.WriteLine("Copied Name: " + person2.Name);
                Console.WriteLine("Copied Age: " + person2.Age);
            }
        }
    }



