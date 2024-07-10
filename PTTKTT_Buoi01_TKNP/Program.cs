using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int target = 5;

        int result = BinarySearch(arr, target);

        if (result != -1)
        {
            Console.WriteLine("Element found at index " + result);
        }
        else
        {
            Console.WriteLine("Element not found in the array");
        }
    }

    static int BinarySearch(int[] arr, int target)
    {
        int low = 0;
        int high = arr.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] == target)
            {
                return mid;
            }
            else if (arr[mid] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        return -1; // not found
    }
}