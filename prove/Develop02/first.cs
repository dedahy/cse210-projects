using System;
using System.Collections;
using System.IO;

public class First
{
    public string _file_name;
    public List<string>_Order = new List<string>();
    DateTime theCurrentTime = DateTime.Now;

    public void Menu()
    {
        int choice = 0;

        while(choice != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1.Write\n2.Display\n3.Load\n4.Save\n5.Quit");
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());

        switch(choice)
        {
            case 1:
            Console.WriteLine("If I had one thing I could do over, what would it be?");
            string sentence = Console.ReadLine();
            string dateText = theCurrentTime.ToShortDateString();
            _Order.Add(dateText);
            _Order.Add(sentence);
            break;            
            case 2:
//            string[] lines = System.IO.File.ReadAllLines(file_name);
//
//            foreach (string line in lines)
//            {
//                string[] parts = line.Split(",");
//
//                string firstName = parts[0];
//                string lastName = parts[1];
//            }
            foreach(string text in _Order)
            {
                Console.WriteLine(text);
            }            
            break;
            case 3:
            Console.WriteLine("Vary");
            break;
            case 4:
            Console.Write("Please enter the file name with its format: ");
            _file_name = Console.ReadLine();
            using (StreamWriter outputFile = new StreamWriter(_file_name))
            {
                foreach(string text in _Order)
                {
                    outputFile.WriteLine(text);
                }
            }
            _Order.Clear();
            Console.WriteLine("Program has been saved.");
            break;
        }
        }
    }
}



//Console.WriteLine("Welcome to the Journal Program!");
        //First menu = new First();
        //menu.Menu();