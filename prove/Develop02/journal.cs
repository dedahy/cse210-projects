using System;

public class Journal
{
    public string _file_name;
    DateTime theCurrentTime = DateTime.Now;

    public List<Entry>_entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        
    }

    public void DisplayAll()
    {

    string[] lines = System.IO.File.ReadAllLines(_file_name);

    foreach (string line in lines)
    {
        Console.WriteLine(line);
    }

    }

    public void SaveToFile(string file)
    {
        
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry item in _entries)
            {
                outputFile.WriteLine(item);
            }
        }

        _entries.Clear();
        Console.WriteLine("Program has been saved.");
    }
    
    public void LoadFromFile(string file)
    {

    }
}