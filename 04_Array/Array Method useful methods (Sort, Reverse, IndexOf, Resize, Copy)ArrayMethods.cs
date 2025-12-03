using System;

class ArrayMethods
{
	static void Main()
	{
		int[] arr = { 5, 2, 9, 1, 3 };

		// Sort
		Array.Sort(arr);
		Console.WriteLine("Sorted: " + string.Join(", ", arr));

		// Reverse
		Array.Reverse(arr);
		Console.WriteLine("Reversed: " + string.Join(", ", arr));

		// IndexOf
		int idx = Array.IndexOf(arr, 9);
		Console.WriteLine("IndexOf 9: " + idx);

		// Copy
		int[] copy = new int[3];
		Array.Copy(arr, 1, copy, 0, 3);
		Console.WriteLine("Copy slice: " + string.Join(", ", copy));

		// Resize
		Array.Resize(ref arr, 7);
		arr[5] = 100;
		arr[6] = 200;
		Console.WriteLine("Resized: " + string.Join(", ", arr));
	}
}
