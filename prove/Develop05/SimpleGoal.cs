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
        _isCompleted = true;
        return GoalPoints();
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