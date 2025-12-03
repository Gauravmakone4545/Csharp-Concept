using System;
using System.Collections.Generic;

class HashSetExample
{
    static void Main()
    {
        HashSet<int> set = new HashSet<int>() { 10, 20, 30, 20, 10 };

        Console.WriteLine("Unique elements:");
        foreach (int x in set)
            Console.WriteLine(x);

        set.Add(40);
        Console.WriteLine("Contains 20: " + set.Contains(20));
    }
}
