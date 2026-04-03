using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.inheritance
{
    internal class AnimalHierarchy
    {
            public string name;
            public int age;

            // Constructor to set values
            public AnimalHierarchy(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            // Virtual method (can be overridden)
            public virtual void MakeSound()
            {
                Console.WriteLine("Animal makes a sound");
            }
        }

        // Subclass Dog
        class Dog : AnimalHierarchy
    {
            public Dog(string name, int age) : base(name, age) { }

            public override void MakeSound()
            {
                Console.WriteLine("Dog barks");
            }
        }

        // Subclass Cat
        class Cat : AnimalHierarchy
    {
            public Cat(string name, int age) : base(name, age) { }

            public override void MakeSound()
            {
                Console.WriteLine("Cat meows");
            }
        }

        // Subclass Bird
        class Bird : AnimalHierarchy
    {
            public Bird(string name, int age) : base(name, age) { }

            public override void MakeSound()
            {
                Console.WriteLine("Bird chirps");
            }
        }

        class Program
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("Choose Animal Type (Dog / Cat / Bird):");
                string choice = Console.ReadLine();

                Console.WriteLine("Enter Animal Name:");
                string animalName = Console.ReadLine();

                Console.WriteLine("Enter Animal Age:");
                int animalAge = int.Parse(Console.ReadLine());

            AnimalHierarchy animal; // parent class reference

                // Creating object 
                if (choice.Equals("Dog", StringComparison.OrdinalIgnoreCase))
                {
                    animal = new Dog(animalName, animalAge);
                }
                else if (choice.Equals("Cat", StringComparison.OrdinalIgnoreCase))
                {
                    animal = new Cat(animalName, animalAge);
                }
                else if (choice.Equals("Bird", StringComparison.OrdinalIgnoreCase))
                {
                    animal = new Bird(animalName, animalAge);
                }
                else
                {
                    Console.WriteLine("Invalid animal type");
                    return;
                }

                // Polymorphism
                Console.WriteLine("\nAnimal Details:");
                Console.WriteLine("Name: " + animal.name);
                Console.WriteLine("Age: " + animal.age);
                animal.MakeSound();
            }
        }
    }


