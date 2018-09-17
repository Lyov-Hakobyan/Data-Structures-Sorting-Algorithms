using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Cyan;
            do
            {
                Clear();
                int[] arr = CreatArray();
                WriteLine("---------------My Array-------------");
                Print(arr);
                Console.WriteLine("1 - Bubble Sort\n2 - Insertion Sort\n3 - Selection Sort\n4 - Merge Sort\n5 - Quicke Sort\n");
                int a = 0;
                int.TryParse(ReadLine(), out a);
                switch (a)
                {
                    case 1:
                        BubbleSort(arr);
                        break;
                    case 2:
                        InsertionSort(arr);
                        break;
                    case 3:
                        SelectionSort(arr);
                        break;
                    case 4:
                        MergeSort(arr);
                        break;
                    case 5:
                        arr = QuickSort(arr);
                        break;
                    default:
                        WriteLine("Wrong Number");
                        return;
                }
                WriteLine("-------------After sort-------------");
                Print(arr);
                WriteLine("PRESS ENTER IF YOU WANT TO TRY AGAIN");
            } while (ReadKey().Key == ConsoleKey.Enter);
            }

        private static int[] CreatArray()
        {
            Random rd = new Random();
            int[] a = new int[rd.Next(10, 11)];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rd.Next(-999, 1000);
            }
            return a;
        }
        private static void Print(int[] arr)
        {
            ForegroundColor = ConsoleColor.Red;
            foreach (int x in arr)
            {
                Write(x + "\t");
            }
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("\n");
        }
        private static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                bool d = true;
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        d = false;
                        arr[j] = arr[j] + arr[j + 1];
                        arr[j + 1] = arr[j] - arr[j + 1];
                        arr[j] = arr[j] - arr[j + 1];
                    }
                }
                if (d == true)
                {
                    break;
                }
            }
        }
        private static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int IndexMinimum = i;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[IndexMinimum] > arr[j])
                    {
                        IndexMinimum = j;
                    }
                }
                if (IndexMinimum != i)
                {
                    arr[i] = arr[i] + arr[IndexMinimum];
                    arr[IndexMinimum] = arr[i] - arr[IndexMinimum];
                    arr[i] = arr[i] - arr[IndexMinimum];
                }
            }
        }
        private static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        arr[j] = arr[j] + arr[j + 1];
                        arr[j + 1] = arr[j] - arr[j + 1];
                        arr[j] = arr[j] - arr[j + 1];
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        private static void MergeSort(int[] input)
        {
            MergeSort(input, 0, input.Length - 1);
        }
        private static void MergeSort(int[] input, int low, int high)
        {
            if (low < high)
            {
                int middle = (low / 2) + (high / 2);
                MergeSort(input, low, middle);
                MergeSort(input, middle + 1, high);
                Merge(input, low, middle, high);
            }
        }

        private static void Merge(int[] input, int low, int middle, int high)
        {

            int left = low;
            int right = middle + 1;
            int[] result = new int[(high - low) + 1];
            int ResultIndex = 0;

            while ((left <= middle) && (right <= high))
            {
                if (input[left] < input[right])
                {
                    result[ResultIndex++] = input[left];
                    left = left + 1;
                }
                else
                {
                    result[ResultIndex++] = input[right];
                    right = right + 1;
                }
            }

            while (left <= middle)
            {
                result[ResultIndex++] = input[left++];
            }
            while (right <= high)
            {
                result[ResultIndex++] = input[right++];
            }
            for (int i = 0; i < result.Length; i++)
            {
                input[low + i] = result[i];
            }
        }
        private static int[] QuickSort(int[] arr)
        {
            Random rd = new Random();
            if (arr.Length <= 1)
                return arr;
            int pivot = rd.Next(0, arr.Length-1);
            int[] res = new int[arr.Length];
            int small = 0, big = arr.Length - 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == pivot)
                    continue;
                if (arr[i] < arr[pivot])
                {
                    res[small] = arr[i];
                    small++;
                }
                else if (arr[i] > arr[pivot])
                {
                    res[big] = arr[i];
                    big--;
                }
                if (small == big)
                    res[small] = arr[pivot];
            }
            int[] LeftSide = new int[small + 1];
            for (int i = 0; i <= small; i++)
            {
                LeftSide[i] = res[i];
            }
            int[] RightSide = new int[res.Length - 1 - small];
            for (int i = 0, j = small + 1; j < res.Length; i++, j++)
            {
                RightSide[i] = res[j];
            }
            return AddArrays(QuickSort(LeftSide), QuickSort(RightSide));
        }
        private static int[] AddArrays(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];
            for (int i = 0, j = 0; i < arr1.Length + arr2.Length; i++)
            {
                if (i < arr1.Length)
                {
                    result[i] = arr1[i];
                }
                else
                {
                    result[i] = arr2[j];
                    j++;
                }
            }
            return result;
        }
    }
}