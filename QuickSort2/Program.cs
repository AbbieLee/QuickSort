using System;

namespace QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 10, 5, 3, 4, 8, 2, 9, 7, 1, 6 };
            int[] numbers = { 12, 45, 23, 6, 78, 43, 21, 36 };
            int n = numbers.Length;
            Console.WriteLine("Unsorted array:");
            PrintArray(numbers); //prints the unsorted array
            QuickSort(numbers, 0, n - 1); //QuickSort function
            Console.WriteLine("\nSorted array:");
            PrintArray(numbers); //prints the sorted array
        }

        static void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int i = Partition(array, low, high); //finds the partitioning index
                QuickSort(array, low, i - 1); //recursively sort elements before partition
                QuickSort(array, i + 1, high); //recursively sort elements after partition
            }
        }

        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high]; //selects the last element as pivot
            int i = low - 1; //index of smaller element

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp1 = arr[i]; //swapping with temporary variable
                    arr[i] = arr[j];
                    arr[j] = temp1;
                }
            }

            int temp2 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp2;

            return i + 1;
        }

        static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}