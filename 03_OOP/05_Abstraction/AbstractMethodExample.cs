using System;

abstract class Animal
{
    public abstract void Sound();
}

class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Dog Barking");
    }
}

class Cat : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Cat Meowing");
    }
}

class Test
{
    static void Main()
    {
        Animal a = new Dog();
        a.Sound();
    }
}
