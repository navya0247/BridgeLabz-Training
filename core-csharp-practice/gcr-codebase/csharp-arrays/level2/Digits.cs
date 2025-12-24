using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level2
{
    internal class Digits
    {
       public static void Main(string[] args)
        {     
            //take input from user
            int number = int.Parse(Console.ReadLine());

            //Count digits
            int temp = number;
            int count = 0;
            while (temp > 0)
            {
                temp = temp / 10;
                count++;
            }


            //Create array 
            int[] arr = new int[count];

            //Store digits in array
            temp = number;
            for(int i = 0; i < count; i++)
            {
                arr[i] = temp % 10;
                temp = temp / 10;
            }

            int lar = int.MinValue;
            int secLar = int.MinValue;

            //Find largest and second largest
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > lar)
                {
                    secLar = lar;
                    lar = arr[i];
                }
                else if (arr[i]>secLar && arr[i] != lar)
                {
                    secLar = arr[i];
                }
            }
            Console.WriteLine("Largest Element is " + lar);
            Console.WriteLine("Second Largest Element is " + secLar);


        }
    }
}
