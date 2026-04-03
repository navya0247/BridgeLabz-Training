using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.methods.level1
{
    internal class Handshake
    {
        public static int CalculateHandshakes(int n)
        {
            return (n * (n - 1)) / 2;                 //calculate the max no of handshakes
        }
        
        public static void Main(String[] args)
        {
            int n = int.Parse(Console.ReadLine());                               //take no of students from user
            int handshake = CalculateHandshakes(n);                              // call method     
            Console.WriteLine("The maximum number of Handshake is " + handshake + " while number of students is " + n);
        }
    }
}

