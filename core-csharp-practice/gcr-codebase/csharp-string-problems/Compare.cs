using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.strings
{
    internal class Compare
{
    //Method to compare two strings
    public bool CompareString(string s1, string s2)
    {
        if (s1.Length != s2.Length)
        {
            return false;
        }
        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i] != s2[i])
            {
                return false;
            }

        }
        return true;

    }

    public static void Main(string[] args)
    {
        //take input from user
        string s1 = Console.ReadLine();

        string s2 = Console.ReadLine();

        Compare obj = new Compare();

        //Method call
        bool result = obj.CompareString(s1, s2);              //using custom method

        bool result2 = s1.Equals(s2);                 //using built-in method

        Console.WriteLine(result);
        Console.WriteLine(result2);

    }
}
}
