using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        
        DateTime theCurrentTime = DateTime.Now;
        int choice = 0;

        //List<string>list = new List<string>();        

        Entry entry = new Entry();

        Journal journal = new Journal();

        entry._promptText.Add("Who was the most interesting person I interacted with today?");
        entry._promptText.Add("What was the best part of my day?");
        entry._promptText.Add("How did I see the hand of the Lord in my life today?");
        entry._promptText.Add("What was the strongest emotion I felt today?");
        entry._promptText.Add("If I had one thing I could do over today, what would it be?");

        while(choice != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1.Write\n2.Display\n3.Load\n4.Save\n5.Quit");
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());

        switch(choice)
        {
            case 1:
            entry.Display();
            
            break;

            case 2:
            journal.DisplayAll();
            break;

            case 4:
            Console.Write("Please enter the file name with its format: ");
            journal._file_name = Console.ReadLine();
            journal.SaveToFile(journal._file_name);
            break;
        }

    }

}

}