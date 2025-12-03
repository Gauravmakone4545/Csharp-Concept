using System;

class SearchingSorting
{
    // Linear Search
    static int LinearSearch(int[] a, int key)
    {
        for (int i = 0; i < a.Length; i++)
            if (a[i] == key) return i;
        return -1;
    }

    // Binary Search (array must be sorted)
    static int BinarySearch(int[] a, int key)
    {
        int l = 0, r = a.Length - 1;
        while (l <= r)
        {
            int mid = l + (r - l) / 2;
            if (a[mid] == key) return mid;
            if (a[mid] < key) l = mid + 1;
            else r = mid - 1;
        }
        return -1;
    }

    // Bubble Sort (simple)
    static void BubbleSort(int[] a)
    {
        for (int i = 0; i < a.Length - 1; i++)
            for (int j = 0; j < a.Length - 1 - i; j++)
                if (a[j] > a[j + 1])
                {
                    int t = a[j]; a[j] = a[j + 1]; a[j + 1] = t;
                }
    }

    // Selection Sort
    static void SelectionSort(int[] a)
    {
        for (int i = 0; i < a.Length - 1; i++)
        {
            int min = i;
            for (int j = i + 1; j < a.Length; j++)
                if (a[j] < a[min]) min = j;
            int t = a[i]; a[i] = a[min]; a[min] = t;
        }
    }

    static void Main()
    {
        int[] arr = { 5, 2, 9, 1, 7 };
        Console.WriteLine("Original: " + string.Join(", ", arr));

        // Linear
        Console.WriteLine("LinearSearch(7): " + LinearSearch(arr, 7));

        // Sort + Binary
        BubbleSort(arr);
        Console.WriteLine("Bubble Sorted: " + string.Join(", ", arr));
        Console.WriteLine("BinarySearch(7): " + BinarySearch(arr, 7));

        // Selection Sort demo
        int[] arr2 = { 4, 6, 1, 9, 3 };
        SelectionSort(arr2);
        Console.WriteLine("Selection Sorted: " + string.Join(", ", arr2));
    }
}
