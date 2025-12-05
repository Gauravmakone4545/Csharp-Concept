using System;

class MyStore<T>
{
    public T Data;

    public void Show()
    {
        Console.WriteLine("Stored Data: " + Data);
    }
}

class GenericClassExample
{
    static void Main()
    {
        MyStore<int> intObj = new MyStore<int>();
        intObj.Data = 100;
        intObj.Show();

        MyStore<string> strObj = new MyStore<string>();
        strObj.Data = "Hello Generics";
        strObj.Show();
    }
}
