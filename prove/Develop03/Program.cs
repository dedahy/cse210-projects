using System;
using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}