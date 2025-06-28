public abstract class Goals
{
    private string _goalName;
    private string _goalDescription;
    private int _goalPoints;
    private bool _isCompleted;

    public Goals()
    {
        _goalName = "";
        _goalDescription = "";
        _goalPoints = 0;
        _isCompleted = false;
    }
    public Goals(string goalName, string goalDescription, int goalPoints, bool isCompleted)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;
        _isCompleted = isCompleted;
    }

    public bool IsGoalCompleted
    {
        get { return _isCompleted; }
    }

    public int GetGoalPoints()
    {
        return _goalPoints;
    }

    public string GetGoalName()
    {
        return $"{_goalName}";
    }

    public string GetGoalDescritpion()
    {
        return $"{_goalDescription}";
    }

    public virtual (string, int, bool) GetGoalInformation()
{
    Console.WriteLine("What is the name of your goal? ");
    _goalName = Console.ReadLine();

    Console.WriteLine("What is a short description of your goal? ");
    _goalDescription = Console.ReadLine();

    Console.WriteLine("How many points is it worth? ");
    string points = Console.ReadLine();
    _goalPoints = int.Parse(points);

    string info = $"{_goalName}, {_goalDescription}";
    return (info, _goalPoints, _isCompleted);
}


    public abstract bool IsGoalComplete();

    public abstract int RecordEvent();


}