public abstract class Goals
{
    private string _goalName;
    private string _goalDescription;
    private int _goalPoints;
    private bool _isCompleted;
    private int _totalPoints;

    public Goals()
    {
        _goalName = "";
        _goalDescription = "";
        _goalPoints = 0;
        _isCompleted = false;
    }
    
    public Goals(string goalName, string goalDescription, int goalPoints)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;
    }

    public int GetGoalPoints()
    {
        return _goalPoints;
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
        return $"{IsGoalComplete()} {_goalName}, {_goalDescription}, {_goalPoints}";
    }

    public abstract int RecordEvent();

    public abstract string IsGoalComplete();
    

}