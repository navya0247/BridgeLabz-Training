using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.leet_code_codebase
{
    internal class RemoveDuplicates
    {
        public int RemovesDuplicates(int[] nums)
        {
            int k = 1;                                  //first element is always unique
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[k] = nums[i];
                    k++;                             //increase count of unique elemets
                }
            }
            return k;                                //number of unique elements

        }

        public static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[] nums = new int[size];

            for(int i = 0; i < size; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            RemoveDuplicates obj = new RemoveDuplicates();

            int uniqueCount = obj.RemovesDuplicates(nums);
            Console.WriteLine(uniqueCount);

            for (int i = 0; i < uniqueCount; i++)
            {
                Console.Write(nums[i] + " ");
            }
            
        
        }
    }
}

