using DSAProject;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int x = 10, y = 20;
        Console.WriteLine($"Before: x = {x}, y = {y}");
        Utility.Swap<int>(ref x, ref y);
        Console.WriteLine($"After: x = {x}, y = {y}");

        string a = "Hello", b = "World";
        Console.WriteLine($"Before: a = {a}, b = {b}");
        Utility.Swap<string>(ref a, ref b);
        Console.WriteLine($"After: a = {a}, b = {b}");
    }
}