using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.constructors
{
    internal class CircleClass
    {
            public double Radius;

            // Default constructor calls parameterized constructor
            public CircleClass() : this(2.0)
            {
            }

            // Parameterized constructor
            public CircleClass(double radius)
            {
                Radius = radius;
            }

            public static void Main(string[] args)
            {
                // Using default constructor
                CircleClass circle1 = new CircleClass();
                Console.WriteLine("Radius: " + circle1.Radius);

                // Using parameterized constructor
                CircleClass circle2 = new CircleClass(7.5);
                Console.WriteLine("Radius: " + circle2.Radius);
            }
        }
    }



