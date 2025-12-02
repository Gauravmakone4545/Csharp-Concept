using System;

class Demo
{
    public static void Show()
    {
        Console.WriteLine("Static Method");
    }
}

class Test
{
    static void Main()
    {
        Demo.Show();
    }
}
