using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BridgeLabzTraining.collections.reflections
{    
       
class MathOperations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }

    internal class DynamicMethodInvocation
    {
       public static void Main(string[] args)
        {
            // Create object normally
            MathOperations obj = new MathOperations();

            Console.Write("Enter method name (Add / Subtract / Multiply): ");
            string methodName = Console.ReadLine();

            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            // Get type information
            Type type = typeof(MathOperations);

            // Get method based on user input
            MethodInfo method = type.GetMethod(methodName);

            if (method == null)
            {
                Console.WriteLine("Invalid method name!");
                return;
            }

            // Call method dynamically
            object result = method.Invoke(obj, new object[] { a, b });

            Console.WriteLine("Result: " + result);
        }
    }

}

