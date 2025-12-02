using System;

class TypeCasting
{
    static void Main()
    {
        // Implicit casting (small ? big)
        int a = 100;
        double b = a;

        // Explicit casting (big ? small)
        double x = 123.45;
        int y = (int)x;

        Console.WriteLine("Implicit: " + b);
        Console.WriteLine("Explicit: " + y);

        // Convert class usage
        string num = "200";
        int z = Convert.ToInt32(num);

        Console.WriteLine("Converted string to int: " + z);

        // Parse()
        string s2 = "200";
        int p = int.Parse(s2);
        Console.WriteLine("Parse string ? int: " + p);

        // TryParse()
        string s3 = "ABC";
        int result;
        bool ok = int.TryParse(s3, out result);

        Console.WriteLine("TryParse success: " + ok);
        Console.WriteLine("Value: " + result); // 0 if failed
    }
}
