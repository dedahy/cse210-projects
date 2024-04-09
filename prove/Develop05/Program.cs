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
        int choice = 0;
        Console.WriteLine();
        while(choice !=6)
        {            
            Console.WriteLine("You have 0 points.\n");
            Console.WriteLine("Menu Options:\n\n    1.Create New Goal\n    2.List Goals\n    3.Save Goals\n    4.Load Goals\n    5.Record Event\n    6.Quit");
            Console.Write("\nSelect a choice from the Menu: ");

            choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Simple s = new Simple("Any Goal", "description", "0", false);

            switch(choice)
            {

                case 1:

                Console.WriteLine("The types of goals are:\n\n    1.Simple Goal\n    2.Eternal Goal\n    3.Checklist Goal\n");             
                 
                Console.WriteLine();
                Console.Write("Which type of goal would you like to create? ");
                //int nbr = int.Parse(Console.ReadLine());
                int nbr = int.Parse(Console.ReadLine());

                s.simple(names, descr, bntimes, check, nbr);

                break;

                case 2:
                s.list_activity(names, descr, check);
                break;

                case 3:

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