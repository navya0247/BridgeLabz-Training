using System;

class CalcSwitch
{
    static void Main(string[] args)
    {
        // Take input from user
        double first = double.Parse(Console.ReadLine());
        double second = double.Parse(Console.ReadLine());
        string op = Console.ReadLine();   

        // Perform operation based on operator using switch 
        switch (op)
        {
            case "+":
                Console.WriteLine("Result: " + (first + second));
                break;

            case "-":
                Console.WriteLine("Result: " + (first - second));
                break;

            case "*":
                Console.WriteLine("Result: " + (first * second));
                break;

            case "/":
                if (second != 0)
                {
                    Console.WriteLine("Result: " + (first / second));
                }
                else
                {
                    Console.WriteLine("Division by zero is not allowed");
                }
                break;

            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}
