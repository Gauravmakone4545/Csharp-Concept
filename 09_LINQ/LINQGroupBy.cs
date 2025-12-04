using System;
using System.Linq;

class LINQGroupBy
{
    static void Main()
    {
        string[] names = { "Gaurav", "Rohan", "Sneha", "Sagar", "Rita" };

        var groups = names.GroupBy(n => n[0]); // group by first letter

        foreach (var g in groups)
        {
            Console.WriteLine($"Group {g.Key}:");
            foreach (var name in g)
                Console.WriteLine(" - " + name);
        }
    }
}
