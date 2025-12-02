using System;

class Animal
{
    public virtual void Sound() => 
    Console.WriteLine("Animal Sound");
}

class Dog : Animal
{
    public override void Sound() => 
    Console.WriteLine("Dog Bark");
}

class Test
{
    static void Main()
    {
        Animal a = new Dog();
        a.Sound();
    }
}
