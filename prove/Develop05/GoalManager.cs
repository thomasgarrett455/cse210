public class GoalManager
{
    private List<Goals> _goals;
    private int _totalScore;
    private string _filename;

    public GoalManager()
    {
        _goals = new List<Goals>();
        _totalScore = 0;
        _filename = "";
    }

    public void AddGoal(Goals goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent()
    {

        Console.WriteLine("Which goal would you like to record an event for?");
        DisplayAllGoals();
        string choice = Console.ReadLine();
        int userInput = int.Parse(choice);
        userInput--;
        if (userInput >= 0 && userInput < _goals.Count)
        {
            int pointsEarned = _goals[userInput].RecordEvent();

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
        Console.WriteLine($"\nYou have {_totalScore} points.");
    }

    public void SaveToFile()
    {
        Console.WriteLine("What is the name of the file?");
        _filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(_filename))
        {
            writer.WriteLine(_totalScore);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.SaveGoalInformation());
            }
        }
    }

    public void LoadFromFile()
    {
        Console.WriteLine("What is the name of the file?");
        _filename = Console.ReadLine();

        if (!File.Exists(_filename))
        {
            Console.WriteLine("File not found.");
            return;
        }
        else
        {
            string[] lines = File.ReadAllLines(_filename); // each line as a string
            string combined = string.Join("#", lines);     // combine all lines with a #
            string[] words = combined.Split('#');

            foreach (string word in words.Skip(1))
            {
            Console.Write(word);
            }
        }
    }

}