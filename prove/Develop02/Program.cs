using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        DateTime theCurrentTime = DateTime.Now;

        Entry entry1 = new Entry();

        Journal journal = new Journal();
        
        journal._file_name= "filename.txt";

        if(File.Exists(journal._file_name)) 
        {
            //We check the file
        }
        else
        {
        using(StreamWriter outputFile = new StreamWriter(journal._file_name))
            {
                //We create the file
            }            
        }  
                    
        int choice = 0;
   
        entry1._promptText.Add("Who was the most interesting person I interacted with today?");
        entry1._promptText.Add("What was the best part of my day?");
        entry1._promptText.Add("How did I see the hand of the Lord in my life today?");
        entry1._promptText.Add("What was the strongest emotion I felt today?");
        entry1._promptText.Add("If I had one thing I could do over today, what would it be?");

        while(choice != 6)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1.Write\n2.Display\n3.Load\n4.Save\n5.Delete File\n6.Quit");
            Console.Write("What would you like to do? ");

            choice = int.Parse(Console.ReadLine());

        switch(choice)
        {
            case 1:
            entry1.Display();
            Console.Write(">>>:");
            journal._text = Console.ReadLine();
            entry1._entryText = $"{theCurrentTime}, {journal._text}";
            journal.AddEntry(entry1._entryText);      
            break;

            case 2:     
            journal.DisplayAll();
            break;

            case 3:
            journal.LoadFromFile(journal._file_name);
            break;

            case 4:
            journal.SaveToFile(journal._file_name);
            break;

            case 5:
            journal.clearFile();
            break;
        }

    }

    }

}