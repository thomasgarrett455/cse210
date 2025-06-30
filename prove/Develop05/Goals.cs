public abstract class Goals
{
    private string _goalName;
    private string _goalDescription;
    private int _goalPoints;
    private int _totalPoints;

    private bool _isCompleted;

    public Goals()
    {
        _goalName = "";
        _goalDescription = "";
        _goalPoints = 0;
        _isCompleted = false;
        _totalPoints = 0;
    }
    public Goals(string goalName, string goalDescription, int goalPoints)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;
    }

    public int GoalPoints()
    {
        return _goalPoints;
    }

    public virtual string DisplayGoalInformation()
    {
        return $"{IsGoalComplete()} {_goalName}, {_goalDescription}, {_goalPoints}";
    }

    public abstract int RecordEvent();

    public abstract string IsGoalComplete();
    

}