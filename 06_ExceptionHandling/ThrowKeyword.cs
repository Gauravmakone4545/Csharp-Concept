using System;

class ThrowKeyword
{
    static void Validate(int number)
    {
        if (number < 0)
            throw new Exception("Number cannot be negative!");
    }

    static void Main()
    {
        try
        {
            Validate(-5);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
