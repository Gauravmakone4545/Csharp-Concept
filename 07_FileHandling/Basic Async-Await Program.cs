using System;
using System.Threading.Tasks;

class AsyncDemo
{
    static async Task Main()
    {
        Console.WriteLine("Program started");

        await ShowAsync();   // await  = wait but no block

        Console.WriteLine("Program ended");
    }

    static async Task ShowAsync()
    {
        Console.WriteLine("Async work started...");

        await Task.Delay(2000);   // 2 seconds wait (non-blocking)

        Console.WriteLine("Async work completed");
    }
}
