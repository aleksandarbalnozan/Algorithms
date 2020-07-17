using System;
using System.Globalization;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 1, 4 };
            sort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        static void sort(int[] arr)
        {
            // [2,3,1,4]
            int n = arr.Length;

            // One by one move boundary of unsorted subarray 
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array 
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                {
                    // replace with new min_idx
                    if (arr[j] < arr[min_idx])
                    {
                        min_idx = j;
                    }
                }
                // Swap the found minimum element with the first 
                // element 
                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
        }

    }
}
