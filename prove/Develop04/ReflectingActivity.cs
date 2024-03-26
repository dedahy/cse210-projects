using System.Diagnostics.CodeAnalysis;

public class ReflectingActivity:Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    DateTime currentTime = DateTime.Now;
    public ReflectingActivity(string name, string description, int time, string promts, string questions):base(name, description, time)
    {
          _prompts.Add(promts);
        _questions.Add(questions);
    }
    
    public void Run()
    {
        string description = "This activity will help you reflect on times in your life when you hae shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        int duration =0;
        Activity activity = new Activity("Reflecting", description, duration);
        activity.DisplayStartingMessage();
        activity.ShowSpinner(5);
        Console.Write($"--- ");
        Thread.Sleep(1000);
        DisplayPrompt();
        Thread.Sleep(500);
        Console.WriteLine(" ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue");
        Console.ReadKey();
        Console.WriteLine("\nNow ponder on each of the following quesstions as they relate to this experience.\n");
        Console.Write("You may begin in: ");
        activity.ShowCountDown(5, 1000);
        Console.WriteLine();

        int time = activity.duration();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);

        while(DateTime.Now < endTime)
        {
            DisplayQuestion();
            activity.ShowSpinner(10);
            Console.WriteLine("\n");            
        }        
     
        activity.DisplayEndingMessage();
        
    }
    public void DisplayPrompt()
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        Random randomGenerator = new Random();
        int someRandomNumber = randomGenerator.Next(0, _prompts.Count());
        Console.Write(_prompts.ElementAt(someRandomNumber)); 
    }

    public void DisplayQuestion()
    {
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

        Random randomGenerator = new Random();
        int someRandomNumber = randomGenerator.Next(0, _questions.Count());
        Console.Write(_questions.ElementAt(someRandomNumber));
    }
    
}