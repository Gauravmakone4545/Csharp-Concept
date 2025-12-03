using System;
using System.Collections.Generic;

class ListExample
{
    static void Main()
    {
        List<int> nums = new List<int>() { 10, 20, 30 };

        nums.Add(40);
        nums.Insert(1, 15);     // index-based insert
        nums.Remove(30);        // remove by value

        Console.WriteLine("List elements:");
        foreach (var n in nums)
            Console.WriteLine(n);

        Console.WriteLine("Count: " + nums.Count);
        Console.WriteLine("Contains 20: " + nums.Contains(20));
    }
}
