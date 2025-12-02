using System;

interface IA { void A(); }
interface IB { void B(); }

class Demo : IA, IB
{
    public void A() => Console.WriteLine("Method A");
    public void B() => Console.WriteLine("Method B");
}

class Test
{
    static void Main()
    {
        Demo d = new Demo();
        d.A();
        d.B();
    }
}
