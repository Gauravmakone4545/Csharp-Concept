using System;
using System.IO;
using System.Threading.Tasks;

class AsyncFileRead
{
    static async Task Main()
    {
        Console.WriteLine("Reading started...");

        string content = await File.ReadAllTextAsync("data.txt");

        Console.WriteLine("File Data: " + content);
    }
}
