using DSAProject;
using System.Diagnostics;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine($"[Main] Thread ID: {Thread.CurrentThread.ManagedThreadId}");

        await WithConfigureAwaitTrue();

        await WithConfigureAwaitFalse();
    }

    static async Task WithConfigureAwaitTrue()
    {
        Console.WriteLine($"\n[WithConfigureAwait(true)] Started on Thread ID: {Thread.CurrentThread.ManagedThreadId}");

        await Task.Delay(10000).ConfigureAwait(true);

        Console.WriteLine($"[WithConfigureAwait(true)] Continued on Thread ID: {Thread.CurrentThread.ManagedThreadId}");
    }

    static async Task WithConfigureAwaitFalse()
    {
        Console.WriteLine($"\n[WithConfigureAwait(false)] Started on Thread ID: {Thread.CurrentThread.ManagedThreadId}");

        await Task.Delay(10000).ConfigureAwait(false);

        Console.WriteLine($"[WithConfigureAwait(false)] Continued on Thread ID: {Thread.CurrentThread.ManagedThreadId}");
    }
}