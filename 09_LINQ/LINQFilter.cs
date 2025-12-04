using System;
using System.Linq;

class LINQFilter
{
    static void Main()
    {
        string[] names = { "Gaurav", "Rahul", "Rohit", "Sneha" };

        var result = names.Where(n => n.StartsWith("R"));

        Console.WriteLine("Names starting with R:");
        foreach (var name in result)
            Console.WriteLine(name);
    }
}
