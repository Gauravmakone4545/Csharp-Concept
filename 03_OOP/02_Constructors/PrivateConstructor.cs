using System;

class Secret
{
    private Secret()
    {
        Console.WriteLine("Private Constructor");
    }

    public static void Show()
    {
        Console.WriteLine("Access using static method");
    }
}

class Test
{
    static void Main()
    {
        Secret.Show();
    }
}
