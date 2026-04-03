using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level1
{
    internal class MultiDimension
    {
        public static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());


            // Create a 2D array matrix with given rows and columns
            int[,] matrix = new int[row, col];


            //Take input values for the 2D array
            for (int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    //Store each element in the matrix
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            //Create a 1D array of size row * col
            int[] arr = new int[row * col];
            int index = 0;

            //Copy elements from 2D array to 1D array
            for (int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    arr[index] = matrix[i, j];
                    index++;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine( arr[i]+ " ");
            }

        }
    }
}
