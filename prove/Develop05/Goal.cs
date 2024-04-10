namespace milestone
{
    public abstract class Goal
    {
        private string _shortname;

        private string _description;

        private string _points;

        public Goal(string name, string description, string points)
        {
            _shortname = name;
            _description = description;
            _points = points;
        }

        public void RecordEvent(List<string>names, List<string>desc, List<int>points)
        {                                    
            Console.WriteLine();
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.WriteLine();
            
            Console.Write("What is the amount of points associated with this goal? ");
            int point = int.Parse(Console.ReadLine());
            Console.WriteLine();
                    
            names.Add(name);
            desc.Add(description);
            points.Add(point);

        }        
        
        
        

        public abstract string GetStringRepresentation();

    }

}