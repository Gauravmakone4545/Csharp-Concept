using System;

class ArrayBasics
{
	static void Main()
	{
		// Declaration + Initialization
		int[] nums = { 1, 2, 3, 4, 5 };

		// Access
		Console.WriteLine("First element: " + nums[0]);

		// Loop through
		for (int i = 0; i < nums.Length; i++)
			Console.WriteLine(nums[i]);

		// foreach
		Console.WriteLine("Using foreach:");
		foreach (var n in nums)
			Console.WriteLine(n);
	}
}
