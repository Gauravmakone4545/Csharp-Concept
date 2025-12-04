using System;
using System.Linq;

class LINQBasics
{
	static void Main()
	{
		int[] nums = { 10, 20, 5, 40, 15 };

		var result = from n in nums
					 where n > 10
					 select n;

		Console.WriteLine("Numbers > 10:");
		foreach (var x in result)
			Console.WriteLine(x);
	}
}
