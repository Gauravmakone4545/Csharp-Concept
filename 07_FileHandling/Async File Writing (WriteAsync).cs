using System;
using System.IO;
using System.Threading.Tasks;

class AsyncFileWrite
{
    static async Task Main()
    {
        Console.WriteLine("Writing started...");

        await File.WriteAllTextAsync("data.txt", "Hello Gaurav, this is async file write!");

        Console.WriteLine("Writing completed.");
    }
}
