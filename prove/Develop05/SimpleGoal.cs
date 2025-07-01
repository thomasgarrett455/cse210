class SimpleGoal : Goals
{
    private bool _isCompleted;
    public SimpleGoal(string goalName, string goalDescription, int goalPoints)
    : base(goalName, goalDescription, goalPoints)
    {

    }
    public SimpleGoal()
    {
        _isCompleted = false;
    }

    public override int RecordEvent()
    {
        if (_isCompleted == true)
        {
            return 0;
        }
        else
        {
            _isCompleted = true;
            return GetGoalPoints();
        }
    }

    public override string IsGoalComplete()
    {
        if (_isCompleted == true)
        {
            return "[x]";
        }
        else
        {
            return "[]";
        }
    }
}