class EternalGoal : Goals
{
    public EternalGoal(string goalName, string goalDescription, int goalPoints)
    : base(goalName, goalDescription, goalPoints)
    {

    }

    public override int RecordEvent()
    {
        return GoalPoints();
    }

    public override string IsGoalComplete()
    {
        return "[]";
    }
}