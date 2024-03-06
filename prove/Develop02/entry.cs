using System;
using System.Collections;
using System.IO;



public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    DateTime theCurrentTime = DateTime.Now;
    

    public void Display()
    {
        string dateText = theCurrentTime.ToShortDateString();
        _promptText = "Who was the most interesting person I interacted with today?";
        _promptText = "What was the best part of my day?";
        _promptText = "How did I see the hand of the Lord in my life today?";
        _promptText = "What was the strongest emotion I felt today?";
        _promptText = "If I had one thing I could do over today, what would it be?";

    }
}