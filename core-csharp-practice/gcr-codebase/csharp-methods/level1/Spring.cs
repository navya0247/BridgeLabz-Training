using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.methods.level1
{
    internal class Spring
    {
        // Method to check Spring Season
        public static bool CheckSeason(int month,int day)
        {
            
            return ((month == 3 && day >= 20) || (month == 4) || (month == 5) || (month == 6 && day <= 20));
        }
        public static void Main(String[] args)
        {

            //take month from user
            int month = int.Parse(Console.ReadLine());

            //take day from user
            int day = int.Parse(Console.ReadLine());

            //Call Method
            bool isSpring = CheckSeason(month, day);

            //check wheather the season is spring or not
            if (isSpring )
            {
                Console.WriteLine("Its a Spring Season");
            }
            else
            {
                Console.WriteLine("Not a Spring Season");
            }
        }
    }
}

