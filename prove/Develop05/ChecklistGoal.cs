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

    public int SetTimesToComplete
    {
        set { _timesToComplete = value; }
    }

    public int SetTimesCompleted
    {
        set { _timesCompleted = value; }
    }

    public int SetBonusPoints
    {
        set { _bonusPoints = value; }
    }

    public override string DisplayGoalInformation()
    {
        return $"{base.DisplayGoalInformation()} -- Currently Completed: {_timesCompleted} / {_timesToComplete}";
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
            Console.WriteLine($"Congratulations! You have earned {GetGoalPoints()} points.");
            return GetGoalPoints();
        }

        else if (_timesCompleted == _timesToComplete)
        {
            Console.WriteLine($"Congratulations! You have earned {GetGoalPoints() + _bonusPoints} points.");
            return _bonusPoints + GetGoalPoints();
        }

        else
        {
            Console.WriteLine("You have already completed this goal.");
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

    public override bool SaveGoalCompletion()
    {
      if (_timesCompleted == _timesToComplete)
        {
            return true;
        }
        else
        {
            return false;
        }  
    }

    public override string ToString()
    {
        return "ChecklistGoal";
    }

    public override string SaveGoalInformation()
    {
        return $"{base.SaveGoalInformation()}#{_timesCompleted}#{_timesToComplete}#{_bonusPoints}";
    }


}

   


