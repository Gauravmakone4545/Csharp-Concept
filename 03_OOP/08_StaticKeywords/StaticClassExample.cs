using System;

static class MathUtility   // static class
{
    public static int Square(int x)
    {
        return x * x;
    }
}

class Test
{
    static void Main()
    {
        Console.WriteLine(MathUtility.Square(5));
    }
}
