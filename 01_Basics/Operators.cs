using System;

class Operators
{
    static void Main()
    {
        int a = 10, b = 3;

        Console.WriteLine("Arithmatic Operators:");
        Console.WriteLine("Add: " + (a + b));
        Console.WriteLine("Sub: " + (a - b));
        Console.WriteLine("Mul: " + (a * b));
        Console.WriteLine("Div: " + (a / b));
        Console.WriteLine("Mod: " + (a % b));

        Console.WriteLine();
        Console.WriteLine("Relational Operators:");
        Console.WriteLine(a > b);
        Console.WriteLine(a < b);
        Console.WriteLine(a == b);
        Console.WriteLine(a != b);

        Console.WriteLine();
        Console.WriteLine("Logical Operators:");
        bool x = true, y = false;
        Console.WriteLine(x && y);
        Console.WriteLine(x || y);
        Console.WriteLine(!x);
    }
}
