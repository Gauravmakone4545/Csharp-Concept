using System;
using System.Collections.Generic;

class GenericListExample
{
    static void Main()
    {
        List<string> names = new List<string>();

        names.Add("Gaurav");
        names.Add("Rahul");
        names.Add("Sneha");

        foreach (var name in names)
            Console.WriteLine(name);
    }
}
