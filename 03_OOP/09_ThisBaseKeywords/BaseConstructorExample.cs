using System;

class Parent
{
    public Parent()
    {
        Console.WriteLine("Parent Constructor");
    }
}

class Child : Parent
{
    public Child() : base()   // calling parent constructor
    {
        Console.WriteLine("Child Constructor");
    }
}

class Test
{
    static void Main()
    {
        Child c = new Child();
    }
}
