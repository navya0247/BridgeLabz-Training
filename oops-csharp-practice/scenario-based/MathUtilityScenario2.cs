using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased
{
    // class providing math operations
    internal class MathUtilitiyScenario2
    {
        // method to find factorial of a number
        public static long CalcFactorial(int value)
        {
            if (value < 0) // check negative
            {
                Console.WriteLine("Negative numbers are not valid for factorial.");
                return -1;
            }

            long output = 1; // starting value
            for (int idx = 2; idx <= value; idx++)
                output = output * idx; 

            return output; // return result
        }

        // method to check if a number is prime
        public static bool CheckIfPrime(int number)
        {
            if (number <= 1) return false; 

            for (int divider = 2; divider <= Math.Sqrt(number); divider++)
                if (number % divider == 0) // divisible means not prime
                    return false;

            return true; 
        }

        // method to find the gcd of two numbers
        public static int FindGcd(int firstNum, int secondNum)
        {
            if (firstNum == 0) return Math.Abs(secondNum);
            if (secondNum == 0) return Math.Abs(firstNum);

            while (secondNum != 0) // loop until second becomes zero
            {
                int store = secondNum; 
                secondNum = firstNum % secondNum; // remainder
                firstNum = store; // swap values
            }

            return Math.Abs(firstNum); // gcd is stored here
        }

        // method to generate fibonacci number 
        public static long FindFibonacci(int term)
        {
            if (term < 0) // invalid case
            {
                Console.WriteLine("Negative value not allowed for Fibonacci.");
                return -1;
            }

            if (term == 0) return 0; // base case
            if (term == 1) return 1; // base case

            long prev = 0; 
            long curr = 1;
            long nxt = 0;

            for (int step = 2; step <= term; step++)
            {
                nxt = prev + curr; // fibonacci formula
                prev = curr;     
                curr = nxt;
            }

            return nxt; // return fib result
        }
    }

    
    class StudentMathRunner
    {
        static void Main(string[] args)
        {
            while (true) // repeat until exit
            {
                Console.WriteLine("\nChoose an operation:");
                Console.WriteLine("1. Factorial");
                Console.WriteLine("2. Prime Check");
                Console.WriteLine("3. GCD");
                Console.WriteLine("4. Fibonacci");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                int option = Convert.ToInt32(Console.ReadLine()); // user choice

                switch (option)
                {
                    case 1:
                        Console.Write("Enter number: ");
                        int factInput = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Factorial: " + MathUtilitiyScenario2.CalcFactorial(factInput));
                        break;

                    case 2:
                        Console.Write("Enter number: ");
                        int primeInput = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(primeInput +
                            (MathUtilitiyScenario2.CheckIfPrime(primeInput) ? " is prime." : " is not prime."));
                        break;

                    case 3:
                        Console.Write("Enter first number: ");
                        int firstVal = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter second number: ");
                        int secondVal = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("GCD: " + MathUtilitiyScenario2.FindGcd(firstVal, secondVal));
                        break;

                    case 4:
                        Console.Write("Enter term: ");
                        int fibTerm = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Fibonacci(" + fibTerm + ") = " + MathUtilitiyScenario2.FindFibonacci(fibTerm));
                        break;

                    case 5:
                        Console.WriteLine("Program Ended.");
                        return; // exit program

                    default:
                        Console.WriteLine("Invalid choice, retry.");
                        break;
                }
            }
        }
    }
}
