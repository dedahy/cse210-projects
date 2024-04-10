namespace milestone
{
    public class GoalManager
    {
        public GoalManager()
        {

        }
//List<int>bonus_times, List<string>check, 
        public void Journal(string filename, List<string>points, List<string>names, List<string>desc, List<Goal>goals)
        {
            Console.WriteLine();                        
            Console.Write("Please enter the file name with its format: ");
            string file = Console.ReadLine();             
            string list = "SimpleGoal EternalGoal ChecklistGoal";
            string[] lists = list.Split(" ");
                using(StreamWriter outputFile = new StreamWriter(filename))
                {
                     outputFile.WriteLine(file);
                }
                using(StreamWriter writer = new StreamWriter(file))
                {
                    writer.WriteLine("0");

                    foreach(Goal goal in goals)
                    {
                        string text = goal.GetStringRepresentation();
                        int i = goals.IndexOf(goal);

                        writer.WriteLine($"{lists[i]}: {names[i]}, {desc[i]}, {points[i]}, {text}");
                    }
                }
        }        
    }
}   