using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 5, 2, 8, 3, 1, 6, 4 };
        Console.WriteLine("Original array:");
        PrintArray(arr);

        MergeSort(arr);

        Console.WriteLine("Sorted array:");
        PrintArray(arr);
    }

    static void MergeSort(int[] arr)
    {
        if (arr.Length <= 1) return;

        int mid = arr.Length / 2;
        int[] left = new int[mid];
        int[] right = new int[arr.Length - mid];

        Array.Copy(arr, 0, left, 0, mid);
        Array.Copy(arr, mid, right, 0, arr.Length - mid);

        MergeSort(left);
        MergeSort(right);

        Merge(left, right, arr);
    }

    static void Merge(int[] left, int[] right, int[] arr)
    {
        int i = 0, j = 0, k = 0;

        while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right[j])
            {
                arr[k++] = left[i++];
            }
            else
            {
                arr[k++] = right[j++];
            }
        }

        while (i < left.Length)
        {
            arr[k++] = left[i++];
        }

        while (j < right.Length)
        {
            arr[k++] = right[j++];
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int element in arr)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}