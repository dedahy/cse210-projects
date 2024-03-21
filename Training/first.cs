using System;
using System.Collections;
using System.IO;



public class Entry
{
/*    DateTime theCurrentTime = DateTime.Now;
    public string _date;
    //public string _promptText;
    public string _entryText;
*/
    public List<string>_promptText = new List<string>();
    public string _file_name;
    public string _text;

    public void Display()
    {
        Console.Write("Please write: ");
        string text = Console.ReadLine();
        _promptText.Add(text);
    }
   
}