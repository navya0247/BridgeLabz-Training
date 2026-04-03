using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.methods.level1
{
    internal class ChocolateTwo
    { 
        //Create the method
       public static int[] FindChocolate(int chocolates,int children)
        {
            int getChocolate = chocolates / children;                           //calculate the chocolate each children can get
            int remChocolate = chocolates % children;                           //calculate the remaining no of chocolates
            return new int[] { getChocolate, remChocolate };

        }
        public static void Main(String[] args)
        {
            int chocolates = int.Parse(Console.ReadLine());                   //take no of chocolates from user
            int children = int.Parse(Console.ReadLine());                     //take no of children from user

            int[] result = FindChocolate(chocolates, children);               //Method Call
            Console.WriteLine("The number of chocolates each child gets is " + result[0] + " and the number of remaining chocolates is " + result[1]);
        }
    }

}

