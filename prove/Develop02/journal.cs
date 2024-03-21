using System;

public class Journal
{
    public string _file_name;
    public string _text;
    DateTime theCurrentTime = DateTime.Now;

    public List<string>_entries = new List<string>();

    public void AddEntry(string newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {

        foreach(string data in _entries)
        {
            Console.WriteLine(data);
        }

    }

    public void SaveToFile(string file)
    {
        if(File.Exists(_file_name))
        { 
                if(new FileInfo(_file_name).Length == 0)
                    {   
                        Console.Write("Please enter the file name with its format: ");
                        file = Console.ReadLine();             
                            using(StreamWriter outputFile = new StreamWriter(_file_name))
                            {
                                outputFile.WriteLine(file);
                            }
                            using(StreamWriter writer = new StreamWriter(file))
                            {
                                foreach(string item in _entries)
                                {
                                    writer.WriteLine(item);
                                }
                            }
                    }    

                else
                    {
                    string[] line = System.IO.File.ReadAllLines(_file_name);

                    foreach(string under_filenale in line)
                    {
                        string[] lines = System.IO.File.ReadAllLines(under_filenale);
                        using (StreamWriter writer = File.AppendText(under_filenale))
                        {
                            foreach (string item in _entries)
                                {
                                    writer.WriteLine(item);
                                }
                        }
                    }
                    
                    foreach(string lin in line)
                    {
                        System.IO.FileInfo fi = new System.IO.FileInfo(lin);

                        Console.Write("Would you like to rename your saved file(yes/no)?");

                        string resp = Console.ReadLine().ToLower();

                        if(resp != "no")
                        {   
                            Console.Write(">>>:");
                            string new_filename = Console.ReadLine();
                            
                            fi.MoveTo(new_filename);

                            using (StreamWriter writer = new StreamWriter(_file_name))
                            {
                                writer.WriteLine(new_filename);
                            }

                        }            

                    }

                    }
                    _entries.Clear();
                    Console.WriteLine("Program has been saved.");                    
        }  
    } 

    public void LoadFromFile(string file)
    {
        try
            {
                if (File.Exists(_file_name)) 
                {
                    string[] line = System.IO.File.ReadAllLines(_file_name);
                    foreach(string under_filenale in line)
                    {
                        string[] lines = System.IO.File.ReadAllLines(under_filenale);
                        foreach(string s in lines)
                        {
                            Console.WriteLine(s.Trim());
                        }
                    }
                }
            }

            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.ToString());
            }
    }

public void clearFile()
{
        if (File.Exists(_file_name)) 
                {
                    string[] line = System.IO.File.ReadAllLines(_file_name);
                    foreach(string under_filenale in line)
                    {
                        string[] lines = System.IO.File.ReadAllLines(under_filenale);
                        File.Delete(under_filenale);
                        System.IO.File.WriteAllText(_file_name,string.Empty);
                        Console.WriteLine("File has been removed.");
                    }
                }
}


}

