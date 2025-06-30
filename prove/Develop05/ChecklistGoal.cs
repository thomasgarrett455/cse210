class CheckListGoal : Goals
{
    private int _timesToComplete;
    private int _timesCompleted;
    private int _bonusPoints;

    public CheckListGoal()
    {
        _timesCompleted = 0;
        _timesToComplete = 0;
        _bonusPoints = 0;
    }
    public CheckListGoal(string goalName, string goalDescription, int goalPoints, int timesToComplete, int timesCompleted, int bonusPoints)
    : base(goalName, goalDescription, goalPoints)
    {
        _timesToComplete = timesToComplete;
        _timesCompleted = timesCompleted;
        _bonusPoints = bonusPoints;
    }

    public override string DisplayGoalInformation()
    {
        return $"{base.DisplayGoalInformation()}, {_timesCompleted} / {_timesToComplete}";
    }

    public override int RecordEvent()
    {
       return _timesCompleted++;
        
    }

    public override string IsGoalComplete()
    {
        if (_timesCompleted == _timesToComplete)
        {
            return "[x]";
        }
        else
        {
            return "[]";
        }
    }


}

   


