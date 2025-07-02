class SimpleGoal : Goals
{
    public SimpleGoal(string goalName, string goalDescription, int goalPoints)
    : base(goalName, goalDescription, goalPoints)
    {

    }
    public SimpleGoal()
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (_isComplete == true)
        {
            Console.WriteLine("You have already completed this goal.");
            return 0;
        }
        else
        {
            _isComplete = true;
            Console.WriteLine($"Congratulations! You have earned {GetGoalPoints()} points.");
            return GetGoalPoints();
        }
    }

    public override string IsGoalComplete()
    {
        if (_isComplete == true)
        {
            return "[x]";
        }
        else
        {
            return "[]";
        }
    }

    public override bool SaveGoalCompletion()
    {

        return _isComplete;
    }

    public override string ToString()
    {
        return "SimpleGoal";
    }
}