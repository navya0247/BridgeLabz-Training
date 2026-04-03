using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.extraBuiltIn.level2
{
    internal class Guessing
    {
         public static void Main(string[] args)
        {
            Random r = new Random();
            int low = 1;
            int high = 100;
            string feedback = "";

            while (feedback != "correct")
            {
                int guess = r.Next(low, high + 1);    // built-in 
                Console.WriteLine("Is your number " + guess + "? (high/low/correct)");
                feedback = Console.ReadLine();

               
                if (feedback == "high")
                {
                    high = guess - 1;
                }
                else if (feedback == "low")
                {
                    low = guess + 1;
                }
            }

            //print result
            Console.WriteLine("Yay! I guessed your number!");
        }
    }

}

