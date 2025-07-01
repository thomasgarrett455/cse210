class EternalGoal : Goals
{
    public EternalGoal(string goalName, string goalDescription, int goalPoints)
    : base(goalName, goalDescription, goalPoints)
    {

    }

    public EternalGoal()
    {

    }

    public override int RecordEvent()
    {
        return GetGoalPoints();
    }

    public override string IsGoalComplete()
    {
        return "[]";
    }
    
    public override string ToString()
    {
        return "EternalGoal";
    }
}