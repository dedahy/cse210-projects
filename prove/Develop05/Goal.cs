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


    }

}