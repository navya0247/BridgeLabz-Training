using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.leetCodeCodebase
{
    internal class TwoSum
    { 
        // create method for two sum
        public int[] TwoSums(int[] nums, int target)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[0];     // if pair not found

        }
        

        public static void Main(string[] args)
        {
            //take input from user
            int n = int.Parse(Console.ReadLine());
            int target = int.Parse(Console.ReadLine());

            int[] nums = new int[n];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            //object creation
            TwoSum obj = new TwoSum();
            int[] result = obj.TwoSums(nums, target);


            //print result
            if (result.Length > 0)
            {
                Console.WriteLine("Result is :" + result[0] + " " + result[1]);
            }
            else
            {
                Console.WriteLine("No pair found for the given target.");
            }

        }
    }
}

