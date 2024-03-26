public class ListingActivity:Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>();

    private List<string> _getprompts = new List<string>();

    private string _file_name = "Sample.txt";

    DateTime currentTime = DateTime.Now;
    public ListingActivity(string name, string description, int duration):base(name, description, duration)
    {

    }

    public void Run()
    {
        string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in certain area.";
        int duration =0;
        Activity activity = new Activity("Listing", description, duration);
        activity.DisplayStartingMessage();
        activity.ShowSpinner(5);
        Console.Write($"--- ");
        Thread.Sleep(1000);
        GetRandomPrompt();
        Thread.Sleep(500);
        Console.WriteLine(" ---");
        Thread.Sleep(1000);
        Console.WriteLine("\nList as many responses you can to the following prompt:\n");
        Console.Write("You may begin in: ");
        activity.ShowCountDown(3, 1000);

        int time = activity.duration();
        
        DateTime future = currentTime.AddSeconds(time);
        while (future > currentTime)
        {
            GetListFromUser();
            _count++;
            currentTime = DateTime.Now;
        }
        Console.WriteLine($"\nYou listed {_count} items.\n");
        activity.DisplayEndingMessage();
        using (StreamWriter writer = new StreamWriter(_file_name))
            {
                foreach (string item in _getprompts)
                    {
                        writer.WriteLine(item);
                    }
            }
    }

    public void GetRandomPrompt()
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

        Random randomGenerator = new Random();
        int someRandomNumber = randomGenerator.Next(0, _prompts.Count());
        string prompt = _prompts.ElementAt(someRandomNumber);
        Console.Write(prompt);
        _getprompts.Add(prompt);
    }

    public void GetListFromUser()
    {
        List<string> list = new List<string>();
        Console.Write("\n>>> ");
        string prompts = Console.ReadLine();
        list.Add(prompts.Trim());
        string gather = $"{currentTime}, {prompts.Trim()}";
        _getprompts.Add(gather);

    }

    public void DisplayPrompt()
    {
            try
            {
                if (File.Exists(_file_name)) 
                {
                    string[] line = System.IO.File.ReadAllLines(_file_name);
                    foreach(string item in line)
                    {
                        {
                            Console.WriteLine(item.Trim());
                        }
                    }
                }
            }

            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.ToString());
            }   
    }

}