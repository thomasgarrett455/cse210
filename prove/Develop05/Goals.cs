public class Goals
{
    private string _goalName;
    private string _goalDescription;
    private int _goalPoints;

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

    public string GetGoalInformation()
    {
        return $"{_goalName}, {_goalDescription}, {_goalPoints}";
    }

    public abstract bool IsGoalComplete();

    public abstract int RecordEvent();


}