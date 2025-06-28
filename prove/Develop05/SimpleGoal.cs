class SimpleGoal : Goals
{
    private int _timesCompleted;

    public SimpleGoal()
    {
        _timesCompleted = 0;
    }

    public SimpleGoal(string goalName, string goalDescription, int goalPoints, bool isCompleted)
    : base(goalName, goalDescription, goalPoints, isCompleted)
    {

    }

    public override bool IsGoalComplete()
    {
        if (!IsGoalCompleted)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override int RecordEvent()
    {
        _timesCompleted++;
        return _timesCompleted;
    }
}