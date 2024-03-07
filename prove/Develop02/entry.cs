using System;
using System.Collections;
using System.IO;



public class Entry
{
    DateTime theCurrentTime = DateTime.Now;
    public string _date;
    //public string _promptText;
    public string _entryText;

    public List<string>_promptText = new List<string>();
    

    public void Display()
    {
        Random randomGenerator = new Random();
        int someRandomNumber = randomGenerator.Next(0, _promptText.Count());
        Console.WriteLine(_promptText.ElementAt(someRandomNumber));
        Console.ReadKey();
    }
}