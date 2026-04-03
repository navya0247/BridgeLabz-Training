using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.methods.level1
{
    internal class PositiveNo
    {
        public static int CheckNumber(int number)
        {
            //check no is positive
            if (number > 0)
            {
                return 1;
            }

            //check no is negative
            else if (number < 0)
            {
                return -1;
            }

            //check no is zero
            else
            {
                return 0;
            }
        }

            public static void Main(String[] args)
            {

                //take number from user
                int number = int.Parse(Console.ReadLine());

            int result = CheckNumber(number);                               //Method Call
            if (result == 1)
            {
                Console.WriteLine("The number is positive");
            }

            else if (result == -1)
            {
                Console.WriteLine("The number is negative");
            }
            else
            {
                Console.WriteLine("The number is zero");
            }
            }
        }
    }
    

