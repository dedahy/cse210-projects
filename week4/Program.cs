using System;
using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop03 World!");
        /*
        Student student = new Student();
        string name = student.GetName();
        string id = student.GetNumber();
        Console.WriteLine(name);        
        Console.WriteLine(id);
        Console.WriteLine($"Name: {name}, id: {id}.");
        */
        Student student = new Student("Dedahy", 12, "0344564245", "2500");
        string name = student.GetName();
        string number = student.GetNumber();
        Console.WriteLine($"{name}, {number}.");
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}