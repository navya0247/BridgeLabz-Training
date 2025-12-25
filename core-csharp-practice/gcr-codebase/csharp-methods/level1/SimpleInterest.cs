using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.methods.level1
{
    internal class SimpleInterest
    {
        public static int CalculateSimpleInterest(int principal,int rate,int time)
        {
            return (principal * rate * time) / 100;
        }
        public static void Main(String[] args)
        {
            int principal = int.Parse(Console.ReadLine());            //take principal as input from user
            int rate = int.Parse(Console.ReadLine());                 //take rate as input from user
            int time = int.Parse(Console.ReadLine());                 //take time as input from user
            int simpleInterest = CalculateSimpleInterest(principal, rate, time);    //call method
            Console.WriteLine("The Simple Interest is " + simpleInterest + " for Principal " + principal + " , Rate of Interest " + rate + " and Time " + time);
        }
    }
}

