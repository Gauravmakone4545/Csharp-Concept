using System;

interface IShape
{
    void Draw();
}

abstract class Shape
{
    public abstract void Print();
}

class Circle : Shape, IShape
{
    public void Draw() => Console.WriteLine("Interface: Draw Circle");
    public override void Print() => Console.WriteLine("Abstract: Print Circle");
}

class Test
{
    static void Main()
    {
        Circle c = new Circle();
        c.Draw();
        c.Print();
    }
}
