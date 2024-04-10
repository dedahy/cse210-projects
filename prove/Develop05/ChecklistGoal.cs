namespace milestone
{
    public class ChecklistGoal : Goal
    {
        private int _amountCompleted;
        private int _target;
        private int _bonus;
        public ChecklistGoal(string name, string desciption, string points, int amount_c, int target, int bonus) : base(name, desciption, points)
        {
            _amountCompleted = amount_c;
            _target = target;
            _bonus = bonus;
        }

        public override string GetStringRepresentation()
        {
            
            return $"{_bonus}, {_target}, {_amountCompleted}";
        }
    }
}