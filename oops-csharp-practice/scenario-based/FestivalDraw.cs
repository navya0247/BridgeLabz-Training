using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased
{
    internal class FestivalDraw
    {
        // method to check lucky number
        public void CheckNumber(int number)
        {
            // check divisible by 3 and 5
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine(" Congratulations! You won a gift.");
            }
            else
            {
                Console.WriteLine(" Sorry! Better luck next time.");
            }
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            FestivalDraw draw = new FestivalDraw(); // object creation
            int choice = 0;

            while (true)
            {
                // menu
                Console.WriteLine("\n Diwali Lucky Draw ");
                Console.WriteLine("1. Enter Visitor Number");
                Console.WriteLine("2. Exit");
                Console.Write("Enter your choice: ");

                // read input as string
                string menuInput = Console.ReadLine();

                // check menu input manually
                if (menuInput != "1" && menuInput != "2")
                {
                    Console.WriteLine("Invalid menu choice.");
                    continue; // skip wrong input
                }

                choice = int.Parse(menuInput);

                if (choice == 2)
                {
                    Console.WriteLine("Thank you for visiting Diwali Mela ");
                    break;
                }

                Console.Write("Enter drawn number: ");
                string numberInput = Console.ReadLine();


                bool valid = true;
                for (int i = 0; i < numberInput.Length; i++)
                {
                    if (numberInput[i] < '0' || numberInput[i] > '9')
                    {
                        valid = false;
                        break;
                    }
                }

                if (!valid || numberInput.Length == 0)
                {
                    Console.WriteLine("Invalid number input.");
                    continue; // skip invalid visitor
                }

                int number = int.Parse(numberInput);

                // call method
                draw.CheckNumber(number);
            }
        }
    }
}
  
    


