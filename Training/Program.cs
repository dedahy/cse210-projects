using System;
using System.IO; 
using System.Collections;
using System.Threading.Tasks.Dataflow;


class Program
{
    static void Main(string[] args)
    {
        string file = "myFile.txt";
        
        try
        {
            if (File.Exists(file)) 
        {
            string[] linese = System.IO.File.ReadAllLines(file);
            foreach(string s in linese)
            {
                Console.WriteLine(s);
            }
        }
        }

        catch
        {
            
        }
        Entry entry = new Entry();
        entry.Display();
        

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (string item in entry._promptText)
            {
                outputFile.WriteLine("+r",item);
                
            }
        }

        string[] lines = System.IO.File.ReadAllLines(file);
        
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

    
    }  
}