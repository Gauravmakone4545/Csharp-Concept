using System;

class A
{
    public void Show()
    {
        Console.WriteLine("Parent Method");
    }
}

class B : A
{
    public void Display()
    {
        base.Show();  // calling parent method
        Console.WriteLine("Child Method");
    }
}

class Test
{
    static void Main()
    {
        B b = new B();
        b.Display();
    }
}
