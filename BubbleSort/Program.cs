using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 7, 1, 3, 2, 4, 5, 6 };
            Console.WriteLine("Unordered array");
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nOrdered array");
            sort(arr);
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }

        private static void sort(int[] arr)
        {
            /*
             * {2,3,1,4}
             * if 2 > 3;
             * if 3 > 1 => swap 3 and 1
             * {2,1,3,4}
             * if 3 > 4;
             * if 2 > 1 => swap 2 and 1
             * {1, 2, 3, 4}
             */
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i -1; j++)
                {
                    if (arr[j] > arr[j + 1]) 
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}
