using System;

class BinarySearch
{
    
    public static int BinarySearchAlgorithm(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (array[mid] == target)
                return mid;
            else if (array[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1; 
    }

   
    static void Main(string[] args)
    {
        int[] arr = { 1, 3, 5, 7, 9 };
        int x = 7;

        int result = BinarySearchAlgorithm(arr, x);

        if (result == -1)
            Console.WriteLine("Элемент не найден");
        else
            Console.WriteLine($"Элемент найден на позиции: {result}");
    }
}