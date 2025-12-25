using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.methods.level2
{
    internal class FriendMethod
    {

        //Method to find youngest friend
        public static int FindYoungest(int[] age)
        {
            int youngestIndex = 0;
            for (int i = 1; i < 3; i++)
            {
                if (age[i] < age[youngestIndex])
                {
                    youngestIndex = i;
                }

            }
            return youngestIndex;
        }
        
        //Method to find tallest friend
        public static int FindTallest(double[] height)
        {
            int tallestIndex = 0;
            for (int i = 1; i < 3; i++)
            {
                if (height[i] > height[tallestIndex])
                {
                    tallestIndex = i;
                }
            }
            return tallestIndex;

        }
            public static void Main(string[] args)
            {
                // Names of friends
                string[] names = { "Amar", "Akbar", "Anthony" };

                // create arrays for age and height
                int[] age = new int[3];
                double[] height = new double[3];

                // Take input from user
                for (int i = 0; i < 3; i++)
                {
                    age[i] = int.Parse(Console.ReadLine());
                    height[i] = double.Parse(Console.ReadLine());
                }

                //Method Call
            int youngestIndex = FindYoungest(age);
            int tallestIndex = FindTallest(height);
              

                // Display results
                Console.WriteLine("Youngest Friend " + names[youngestIndex]);
                Console.WriteLine("Tallest Friend " + names[tallestIndex]);
            }
        }
    }



