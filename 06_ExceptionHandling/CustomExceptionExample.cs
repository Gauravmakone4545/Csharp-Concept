using System;

class AgeException : Exception
{
    public AgeException(string message) : base(message) { }
}

class CustomExceptionExample
{
    static void Main()
    {
        try
        {
            int age = 15;

            if (age < 18)
                throw new AgeException("Age must be 18 or above.");

            Console.WriteLine("Valid age");
        }
        catch (AgeException ex)
        {
            Console.WriteLine("Custom Exception: " + ex.Message);
        }
    }
}
