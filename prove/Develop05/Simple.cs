namespace milestone
{
    public class Simple : Goal
    {
        private bool _isComplete;
        //public List<string> activity = new List<string>();
        public Simple(string name, string description, string points,bool isComplete) : base(name, description, points)
        {
            _isComplete = isComplete;
        }
        /*

        public void simple(List<string>names, List<string>desc, List<int>points,List<int>bonus_times, List<string>check, int nbr)
        {
            string name = "";
            string description = "";
                                    
            Console.WriteLine();
            Console.Write("What is the name of your goal? ");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("What is a short description of it? ");
            description = Console.ReadLine();
            Console.WriteLine();
            
            Console.Write("What is the amount of points associated with this goal? ");
            int point = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if(nbr == 3)
            {
                Console.Write("How many times does this goal need to be accomplished? ");
                int rp = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("What is the bonus for accomplishing it that many times");

                int bn = int.Parse(Console.ReadLine());
                Console.WriteLine();

                bonus_times.Add(rp);

                string text = $"-- Currently Completed 0/{bonus_times[0]}";                

                check.Add(text);

            }
            else
            {
                check.Add("");
            }
                    
            names.Add(name);
            desc.Add(description);
            points.Add(point);


        }

        public void list_activity(List<string>names, List<string>desc, List<string>check)
        {
            Console.WriteLine("The goals are:");
            Console.WriteLine();
            int count = 0;
            foreach(string item in names)
            {
                int i = names.IndexOf(item);
                count++;
                Console.WriteLine($"{count}. [ ] {item} ({desc[i]}) {check[i]}");
            }
            
            Console.WriteLine();

        }
        public string list()
        {
            return $"";//activity[0]}";
        }

        public void Journal(string filename, List<int>points, List<string>names, List<string>desc, List<int>bonus_times, List<string>check)
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
                    foreach(string item in names)
                    {
                        int i = names.IndexOf(item);                        

                        writer.WriteLine("0");
                        writer.WriteLine($"{lists[i]}: {names}, {desc[i]}, {points[i]}, {false}");
                    }
                }
        }
        */
                                

        public override string GetStringRepresentation()
        {
            return $"{_isComplete}";
        }
    }
}