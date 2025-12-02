using System;

class A
{
    public void Show() => 
    Console.WriteLine("A Show");
}

class B : A
{
    public new void Show() =>
    Console.WriteLine("B Show (Hidden)");
}

class Test
{
    static void Main()
    {
        B b = new B();
        b.Show();
    }
}
