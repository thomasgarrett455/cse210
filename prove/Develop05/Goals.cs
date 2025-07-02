using System.Dynamic;

public abstract class Goals
{
    private string _goalName;
    private string _goalDescription;
    private int _goalPoints;
    private string _goalType;
    protected bool _isComplete;

    public Goals()
    {
        _goalName = "";
        _goalDescription = "";
        _goalPoints = 0;
    }

    public Goals(string goalName, string goalDescription, int goalPoints)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;
    }

    public string SetGoalName
    {
        set { _goalName = value; }
    }

    public int GetGoalPoints()
    {
        return _goalPoints;
    }

    public int SetGoalPoints
    {
        set { _goalPoints = value; }
    }

    public string SetGoalDescription
    {
        set { _goalDescription = value; }
    }

    public bool SetGoalCompletion
    {
        set{ _isComplete = value; }
    }
    public string GetGoalType()
    {
        return _goalType;
    }

    public virtual void GoalInformation()
    {
        Console.WriteLine("What is the name of your goal?");
        _goalName = Console.ReadLine();

        Console.WriteLine("What is a short description of your goal?");
        _goalDescription = Console.ReadLine();

        Console.WriteLine("How many points are associated with doing the goal?");
        string points = Console.ReadLine();
        _goalPoints = int.Parse(points);

    }

    public virtual string DisplayGoalInformation()
    {
        return $"{IsGoalComplete()} {_goalName} ({_goalDescription})";
    }

    public abstract int RecordEvent();

    public abstract string IsGoalComplete();

    public override string ToString()
    {
        return "";
    }

    public virtual string SaveGoalInformation()
    {
        return $"{ToString()}#{SaveGoalCompletion()}#{_goalName}#{_goalDescription}#{_goalPoints}";
    }

    public abstract bool SaveGoalCompletion();
    
}