using System;

delegate void PrintMessage(string msg);

class DelegateWithParameters
{
    static void Display(string msg)
    {
        Console.WriteLine("Message: " + msg);
    }

    static void Main()
    {
        PrintMessage del = Display;
        del("Hello Gaurav!");
    }
}
