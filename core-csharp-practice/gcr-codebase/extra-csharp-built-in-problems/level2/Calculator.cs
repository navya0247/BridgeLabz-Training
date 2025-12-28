using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.extraBuiltIn.level2
{
    internal class Calculator
    {   
        //methods for arithmetic operations
       public static double Add(double a, double b) { 
            return a + b; 
        }
       public static double Sub(double a, double b)
        { 
            return a - b;
        }
        public static double Mul(double a, double b) {
            return a * b; 
        }
        public static double Div(double a, double b) { 
            return a / b; 
        }

        public static void Main(string[] args)
        {
            //take input from user
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());

           
            int outp = Convert.ToInt32(Console.ReadLine());

            if (outp == 1)
            {
                Console.WriteLine("Result " + Add(num1, num2));
            }
            else if (outp == 2)
            {
                Console.WriteLine("Result " + Sub(num1, num2));
            }
            else if (outp == 3)
            {
                Console.WriteLine("Result " + Mul(num1, num2));
            }
            else if (outp == 4)
            {
                Console.WriteLine("Result " + Div(num1, num2));
            }
            else
            {
                Console.WriteLine("Invalid operation");
            }
        }
    }

}

