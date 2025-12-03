//Anonymous function using delegate

using System;

delegate void MyDel();

class AnonymousDelegate
{
    static void Main()
    {
        MyDel del = delegate ()
        {
            Console.WriteLine("Anonymous delegate called!");
        };

        del();
    }
}
