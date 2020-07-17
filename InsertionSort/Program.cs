using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 1, 4 };
            foreach (var item in sort(arr))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        private static int[] sort(int[] arr)
        {
            // [2,3,1,4]
            for (int i = 1; i < arr.Length; i++)
            {
                int value = arr[i];
                int j = i - 1;


                while (j >= 0 && arr[j] > value)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = value;
            }
            return arr;
        }
    }
}
