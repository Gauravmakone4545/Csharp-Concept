using System;
using System.Collections.Generic;

class DictionaryExample
{
    static void Main()
    {
        Dictionary<int, string> students = new Dictionary<int, string>();

        students.Add(1, "Gaurav");
        students.Add(2, "Rahul");
        students.Add(3, "Sneha");

        Console.WriteLine("All students:");
        foreach (var item in students)
            Console.WriteLine(item.Key + " → " + item.Value);

        Console.WriteLine("Access key 2: " + students[2]);
    }
}
