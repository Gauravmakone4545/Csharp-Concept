using System;
using System.Collections.Generic;

class StackExample
{
    static void Main()
    {
        Stack<int> st = new Stack<int>();

        st.Push(10);
        st.Push(20);
        st.Push(30);

        Console.WriteLine("Top element: " + st.Peek());

        Console.WriteLine("Popping: " + st.Pop());

        Console.WriteLine("Stack left:");
        foreach (var x in st)
            Console.WriteLine(x);
    }
}
