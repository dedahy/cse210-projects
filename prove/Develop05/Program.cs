using System;
using System.Collections;
using System.Diagnostics;
using milestone;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
class Program
{
    static void Main(string[] args)
    {
        List<string> names = new List<string>();
        List<string> descr = new List<string>();
        List<string> check = new List<string>();
        List<int> bntimes = new List<int>();
        List<int> target = new List<int>();
        List<string> points = new List<string>();


        List<Goal> goals = new List<Goal>();

        string filename = "file.txt";

        if(File.Exists(filename)) 
        {
            //We check the file
        }
        else
        {
        using(StreamWriter outputFile = new StreamWriter(filename))
            {
                //We create the file
            }            
        }  

        int choice = 0;
        Console.WriteLine();
        while(choice !=6)
        {   
            //points.Add(0);
            Console.WriteLine($"You have 0 points.\n");
            Console.WriteLine("Menu Options:\n\n    1.Create New Goal\n    2.List Goals\n    3.Save Goals\n    4.Load Goals\n    5.Record Event\n    6.Quit");
            Console.Write("\nSelect a choice from the Menu: ");

            choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            

        static void RecordEvent(List<string>names, List<string>desc, List<string>points, int nbr, List<int>repeatTime, List<int>bntimes, List<string>check)
        {                                    
            Console.WriteLine();
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.WriteLine();
            
            Console.Write("What is the amount of points associated with this goal? ");
            string point = Console.ReadLine();
            Console.WriteLine();
                    
            names.Add(name);
            desc.Add(description);
            points.Add(point);

            if(nbr == 3)
            {
                Console.Write("How many times does this goal need to be accomplished? ");
                int rp = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("What is the bonus for accomplishing it that many times");

                int bn = int.Parse(Console.ReadLine());
                Console.WriteLine();

                repeatTime.Add(rp);
                bntimes.Add(bn);

                string text = $"-- Currently Completed: 0/{repeatTime[2]}";
                Console.WriteLine();     

                check.Add(text);

            }
            else
            {
                check.Add("");
                repeatTime.Add(0);
                bntimes.Add(0);
            }

        }

            switch(choice)
            {

                case 1:
                
                Console.WriteLine("The types of goals are:\n\n    1.Simple Goal\n    2.Eternal Goal\n    3.Checklist Goal\n");
                Console.WriteLine();
                Console.Write("Which type of goal would you like to create? ");
                int nbr = int.Parse(Console.ReadLine());
        
                switch(nbr)
                {
                    case 1:
                    RecordEvent(names, descr, points, nbr, target, bntimes, check);
                    break;

                    case 2:
                    RecordEvent(names, descr, points, nbr, target, bntimes, check);
                    break;

                    case 3:
                    RecordEvent(names, descr, points, nbr, target, bntimes, check);
                    break;                    
                }

                break;

                case 2:

                    Console.WriteLine("The goals are:");
                    Console.WriteLine();

                    int i = 0;
                    foreach(string item in names)
                    {
                        i++;
                        int index = names.IndexOf(item);
                        Console.WriteLine($"{i}. [ ] {item} ({descr[index]}) {check[index]}");
                    }
                    Console.WriteLine();
                
                break;

                case 3:

                Simple S = new Simple(names[0], descr[0], points[0], false);                
                Internal I = new Internal(names[1], descr[1], points[1]);
                ChecklistGoal C = new ChecklistGoal(names[2], descr[2], points[2], 0, target[2], bntimes[2]);

                goals.Add(S);
                goals.Add(I);
                goals.Add(C);


                GoalManager G = new GoalManager();

                foreach(Goal goal in goals)
                {
                    string text = goal.GetStringRepresentation();
                    
                    Console.WriteLine(text);
                }

                G.Journal(filename, points, names, descr, goals);
                                
                break;            

                case 4:

                break;

                case 5:

                break;                

            }
        }
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}