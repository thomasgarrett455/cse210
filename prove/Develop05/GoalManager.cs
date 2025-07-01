public class GoalManager
{
    private List<Goals> _goals;
    private int _totalScore;

    public GoalManager()
    {
        _goals = new List<Goals>();
        _totalScore = 0;
    }

    public void AddGoal(Goals goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            int pointsEarned = _goals[goalIndex].RecordEvent();

            _totalScore += pointsEarned;
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }

    public void DisplayAllGoals()
    {
        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].DisplayGoalInformation()}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"\nYour total score is: {_totalScore}");
    }
}