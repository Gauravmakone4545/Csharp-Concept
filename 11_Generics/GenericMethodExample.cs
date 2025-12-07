using System;

class GenericMethodExample
{
    static void Display<T>(T msg)
    {
        Console.WriteLine("Message: " + msg);
    }

    static void Main()
    {
        Display<int>(50);
        Display<string>("Welcome Gaurav!");
        Display<double>(45.66);
    }
}
