using System;
using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
class Program
{
    static void Main(string[] args)
    {
           
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}