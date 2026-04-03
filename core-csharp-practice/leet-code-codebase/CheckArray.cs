using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.leet_code_codebase
{
    internal class CheckArray
    {
            public bool Check(int[] nums)
            {
                int count = 0;
                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[i] < nums[i - 1])
                    {
                        count++;
                    }

                }
                if (nums[0] < nums[nums.Length - 1])
                {
                    count++;
                }
                return count <= 1;

            }
             public static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[] nums = new int[size];

            for(int i = 0; i < size; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            CheckArray obj = new CheckArray();
            bool result = obj.Check(nums);

            if (result)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }
        }
    }

