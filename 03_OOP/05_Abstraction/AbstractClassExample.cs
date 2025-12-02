using System;

abstract class Shape
{
    public abstract void Draw();  // Abstract method
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing Circle");
    }
}

class Test
{
    static void Main()
    {
        Shape s = new Circle();
        s.Draw();
    }
}
