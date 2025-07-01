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

    public override void GoalInformation()
    {
        base.GoalInformation();

        Console.WriteLine("How many times do you need to do this goal?");
        string times = Console.ReadLine();
        _timesToComplete = int.Parse(times);

        Console.WriteLine("How many bonus points for completing this goal?");
        string bonus = Console.ReadLine();
        _bonusPoints = int.Parse(bonus);
    }

    public override int RecordEvent()
    {
        _timesCompleted++;

        if (_timesCompleted < _timesToComplete)
        {
            return GetGoalPoints();
        }

        else if (_timesCompleted == _timesToComplete)
        {
            return _bonusPoints + GetGoalPoints();
        }

        else
        {
            return 0;
        }
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

   


