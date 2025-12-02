using System;

class Demo
{
    public static int Count;

    static Demo()
    {
        Count = 10;
        Console.WriteLine("Static Constructor Called");
    }

    public Demo()
    {
        Console.WriteLine("Instance Constructor");
    }
}

class Test
{
    static void Main()
    {
        Demo d1 = new Demo();
        Demo d2 = new Demo();
    }
}
