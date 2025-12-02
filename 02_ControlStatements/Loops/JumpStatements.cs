using System;

class JumpStatements
{
    static void Main()
    {
        for (int i = 1; i <= 5; i++)
        {
            if (i == 3)
                continue; // skip

            if (i == 5)
                break;    // exit

            Console.WriteLine(i);
        }
    }
}
