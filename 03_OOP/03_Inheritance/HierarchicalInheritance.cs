using System;

class Animal
{
    public void Eat() => Console.WriteLine("Eating");
}

class Dog : Animal
{
    public void Bark() => Console.WriteLine("Bark");
}

class Cat : Animal
{
    public void Meow() => Console.WriteLine("Meow");
}

class Test
{
    static void Main()
    {
        Dog d = new Dog();
        d.Eat();
        d.Bark();
    }
}
