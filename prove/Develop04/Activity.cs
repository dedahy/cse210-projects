using System.Data;

public class Activity
{  
    DateTime startTime = DateTime.Now;

    DateTime currentTime = DateTime.Now;
    
    private string _name;
    private string _desciption;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _desciption = description;
        _duration = duration;

    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine(_desciption);
        Console.WriteLine();        
        Console.Write($"How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Get ready...\n");
        
    }

    public int duration()
    {
        return _duration;
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!!\n");
        ShowSpinner(5);
        Console.WriteLine($"You have completed another {_duration} seconds of the Breathing Activity.\n");
        ShowSpinner(5);
    }
    public void ShowSpinner(int seconds)
    {
        
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");


        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while(DateTime.Now < endTime)
        {
            string  symbol = animationStrings[i];
            Console.Write(symbol);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if(i >= animationStrings.Count)
            {
                i = 0;
            }
        }

   }
    public void ShowCountDown(int e, int seconds)
    {       
            for(int i = e; i>0; i--)
            {
                Console.Write(i);
                Thread.Sleep(seconds);
                Console.Write("\b \b");
            }
            Console.WriteLine();
        }        

}
