using System;
using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
class Program
{
    static void Main(string[] args)
    {   int choice = 0;
        while(choice !=5)
        {
            Console.WriteLine("Menu Options:\n\n    1.Start Breathing activity\n    2.Start Reflecting activity\n    3.Start Listing activty\n    4.Load File\n    5.Quit");
            Console.Write("\nSelect a choice from the Menu: ");            
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine();
            string name = "";
            string descr = "";
            int time = 0;

            switch(choice)
            {
                case 1:
                //function from Breathing activity
                BreathingActivity ba = new BreathingActivity(name, descr, time);
                ba.Run();
                break;
                
                case 2:
                //Reflecting 
                string prompt = "";
                string question = "";
                ReflectingActivity ra = new ReflectingActivity(name, descr, time, prompt, question);
                ra.Run();
                break;

                case 3:
                //Listing Activity
                ListingActivity la = new ListingActivity(name, descr, time);
                la.Run();
                break;

                case 4:
                ListingActivity La = new ListingActivity(name, descr, time);
                La.DisplayPrompt();
                break;
            }
            
        }
        
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}