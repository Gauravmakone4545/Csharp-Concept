using System;

class HandleSpecificExceptions
{
    static void Main()
    {
        try
        {
            int a = int.Parse("abc"); // FormatException
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Invalid number format!");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Something went wrong: " + ex.Message);
        }
    }
}
