using System;
using System.Linq;

class LINQOrderBy
{
	static void Main()
	{
		int[] nums = { 20, 5, 40, 10, 15 };

		var asc = nums.OrderBy(n => n);
		var desc = nums.OrderByDescending(n => n);

		Console.WriteLine("Ascending:");
		foreach (var n in asc)
			Console.WriteLine(n);

		Console.WriteLine("\nDescending:");
		foreach (var n in desc)
			Console.WriteLine(n);
	}
}
