
 
    internal class QuickSort
        {
            public static void Main(string[] args)
            {
                // Ask user for size of array
                Console.Write("Enter number of elements: ");
                int n = int.Parse(Console.ReadLine());

                int[] arr = new int[n];

                // Take array elements from user
                Console.WriteLine("Enter array elements:");
                for (int i = 0; i < n; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("\nArray before sorting:");
                PrintArray(arr);

                // Call Quick Sort
                QuickSortArray(arr, 0, n - 1);

                Console.WriteLine("\nArray after sorting:");
                PrintArray(arr);
            }

            // Quick Sort method using recursion
            static void QuickSortArray(int[] arr, int start, int end)
            {
                if (start < end)
                {
                    // Get pivot index
                    int pivotIndex = Partition(arr, start, end);

                // Sort left side
                 QuickSortArray(arr, start, pivotIndex - 1);

                    // Sort right side
                    QuickSortArray(arr, pivotIndex + 1, end);
                }
            }

            // Partition method
            static int Partition(int[] arr, int start, int end)
            {
                int pivot = arr[end];   // Last element as pivot
                int i = start - 1;

                for (int j = start; j < end; j++)
                {
                    if (arr[j] < pivot)
                    {
                        i++;

                        // Swap elements
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }

                // Place pivot at correct position
                int swap = arr[i + 1];
                arr[i + 1] = arr[end];
                arr[end] = swap;

                return i + 1;
            }

            // Print array method
            static void PrintArray(int[] arr)
            {
                foreach (int num in arr)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    



