using System;

class Demo
{
    static Demo()
    {
        Console.WriteLine("Static Constructor");
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
