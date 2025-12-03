using System;
using System.Collections.Generic;

class SortedListExample
{
    static void Main()
    {
        SortedList<int, string> sl = new SortedList<int, string>();

        sl.Add(3, "Three");
        sl.Add(1, "One");
        sl.Add(2, "Two");

        Console.WriteLine("Sorted List (sorted by key):");
        foreach (var x in sl)
            Console.WriteLine(x.Key + ": " + x.Value);
    }
}
