using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.methods.level1
{
    internal class AthleteRounds
    {
        public static int CalculateRounds(int side1, int side2, int side3)
        {
            int  distance = 5000;
            int perimeter = side1 + side2 + side3;                         //calculate the perimeter
            int rounds = distance / perimeter;                            //calculate the rounds completed by athlete
            return rounds;                             
        }

       
        public static void Main(String[] args)
        {
            int side1 = int.Parse(Console.ReadLine());                //take first side of triangle from user
            int side2 = int.Parse(Console.ReadLine());                 //take second side of triangle from user
            int side3 = int.Parse(Console.ReadLine());                  //take third side of triangle from user

            int rounds = CalculateRounds(side1, side2, side3);           //method call
            Console.WriteLine("The total number of rounds the athlete will run is " + rounds + " to complete 5 km");
        }
    }

}


