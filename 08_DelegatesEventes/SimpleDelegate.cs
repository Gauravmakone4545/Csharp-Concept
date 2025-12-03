using System;

delegate void MyDelegate();

class SimpleDelegate
{
    static void Show()
    {
        Console.WriteLine("Delegate called!");
    }

    static void Main()
    {
        MyDelegate del = Show;  // reference
        del();                  // invoke
    }
}
