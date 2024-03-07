using System;
using System.IO;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        List<string>list = new List<string>();
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Age: ");
        string age = Console.ReadLine();
        list.Add(name);
        list.Add(age);

        string fileName = "myFile.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach(string item in list)
            {
                outputFile.WriteLine(item);
            }
        }

        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
           Console.WriteLine(line);
        }

}

}