public class BreathingActivity : Activity
{
    
    public BreathingActivity(string name, string description, int duration):base(name, description, duration)
    {
        
    }

    public void Run()
    {   
        string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on our breathing.";
        int duration = 0;
        Activity activity = new Activity("Breathing", description, duration);
        activity.DisplayStartingMessage();
        activity.ShowSpinner(5);

        int time = activity.dura[0];

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);

        int i = 0;

        while(DateTime.Now < endTime)
        {

            Console.Write($"Breathe in...");
            activity.ShowCountDown(4,1000);
            Console.Write($"Breathe out...");
            activity.ShowCountDown(6,1000);
            Console.WriteLine();

            i++;

        }
        activity.dura.Clear();
        
        activity.DisplayEndingMessage();
        
    }
}