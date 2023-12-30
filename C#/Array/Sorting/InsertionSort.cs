﻿namespace Array.Sorting
{
    internal class InsertionSort
    {
        void insertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }

        void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine("");
        }

        public void Main()
        {
            int[] arr = { 12, 11, 13, 5, 6 };

            insertionSort(arr);
            printArray(arr);
        }
    }
}
