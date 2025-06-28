public class GoalManager
{
    private List<Goals> _goals;

    public GoalManager()
    {
        _goals = new List<Goals>();
    }
    
    public void AddGoal(Goals goal)
    {
        _goals.Add(goal);
    }

    public void ShowGoals()
    {
        Console.WriteLine("\nYour Goals:");
        if (_goals.Count == 0)
        {
            Console.WriteLine("You have not created any goals yet.");
            return;
        }

        int index = 1;
        foreach (Goals goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetGoalInformation()}");
            index++;
        }
    }

    public List<Goals> GetGoals()
    {
        return _goals;
    }
}