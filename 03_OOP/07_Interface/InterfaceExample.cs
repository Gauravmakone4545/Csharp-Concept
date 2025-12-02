using System;

interface IVehicle
{
    void Start();
}

class Car : IVehicle
{
    public void Start() => Console.WriteLine("Car Started");
}

class Test
{
    static void Main()
    {
        IVehicle v = new Car();
        v.Start();
    }
}
