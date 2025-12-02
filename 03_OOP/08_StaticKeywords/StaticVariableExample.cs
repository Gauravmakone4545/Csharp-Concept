using System;

class Counter
{
    public static int count = 0;

    public Counter()
    {
        count++;
    }
}

class Test
{
    static void Main()
    {
        new Counter();
        new Counter();
        new Counter();

        Console.WriteLine("Objects Created: " + Counter.count);
    }
}
