using System;

interface IA { void A(); }
interface IB { void B(); }

class Demo : IA, IB
{
    public void A() => Console.WriteLine("A");
    public void B() => Console.WriteLine("B");
}

class Test
{
    static void Main()
    {
        Demo obj = new Demo();
        obj.A();
        obj.B();
    }
}
