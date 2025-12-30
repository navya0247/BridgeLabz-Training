using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.leetCodeCodebase
{
    internal class MissingNo
    {
            // Method to find missing number
            public int MissingNumber(int[] nums)
            {
            int n = nums.Length;
                int expectedSum = (n * (n + 1)) / 2;
                int actualSum = 0;


                for (int i = 0; i < nums.Length; i++)
                {

                    actualSum += nums[i];

                }
                return expectedSum - actualSum;

            }
        public static void Main(string[] args)
        {
            //take input from user
            int n = int.Parse(Console.ReadLine());

            int[] nums = new int[n];
            for(int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            //object creation
            MissingNo missingNo = new MissingNo();


            
            int result = missingNo.MissingNumber(nums);

            //print result
            Console.WriteLine("Missing number is:" + result);

        }
        }
    }

