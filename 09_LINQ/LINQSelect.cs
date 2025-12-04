using System;
using System.Linq;

class LINQSelect
{
    static void Main()
    {
        int[] nums = { 1, 2, 3, 4 };

        var squares = nums.Select(n => n * n);

        Console.WriteLine("Squares:");
        foreach (var s in squares)
            Console.WriteLine(s);
    }
}
