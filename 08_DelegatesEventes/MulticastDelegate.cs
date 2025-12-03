using System;

delegate void MultiDel();

class MulticastDelegate
{
    static void Method1()
    {
        Console.WriteLine("Method 1 called");
    }
                                             //One delegate calling multiple methods
    static void Method2()
    {
        Console.WriteLine("Method 2 called");
    }

    static void Main()
    {
        MultiDel del = Method1;
        del += Method2;     // add 2nd method

        del();              // calls both
    }
}
