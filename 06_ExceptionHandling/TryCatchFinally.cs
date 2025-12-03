using System;

class TryCatchFinally
{
    static void Main()
    {
        try
        {
            int a = 10;
            int b = 0;
            int result = a / b;  // exception
            Console.WriteLine(result);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Finally block executed.");
        }
    }
}
