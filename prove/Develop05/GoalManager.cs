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
            string[] lines = File.ReadAllLines(_filename);
            _totalScore = int.Parse(lines[0]);
            foreach (string line in lines.Skip(1))
            {
                string[] parts = line.Split("#");
                string goalType = parts[0];
                bool goalCompletion = bool.Parse(parts[1]);
                string goalName = parts[2];
                string goalDescription = parts[3];
                int goalPoints = int.Parse(parts[4]);

                switch (goalType)
                {
                    case "SimpleGoal":
                        SimpleGoal simpleGoal = new SimpleGoal();
                        {
                            simpleGoal.SetGoalCompletion = goalCompletion;
                            simpleGoal.SetGoalName = goalName;
                            simpleGoal.SetGoalDescription = goalDescription;
                            simpleGoal.SetGoalPoints = goalPoints;
                            AddGoal(simpleGoal);
                        }
                        break;

                    case "EternalGoal":
                        EternalGoal eternalGoal = new EternalGoal();
                        {
                            eternalGoal.SetGoalCompletion = goalCompletion;
                            eternalGoal.SetGoalName = goalName;
                            eternalGoal.SetGoalDescription = goalDescription;
                            eternalGoal.SetGoalPoints = goalPoints;
                            AddGoal(eternalGoal);
                        }
                        break;

                    case "ChecklistGoal":
                        int timesCompleted = int.Parse(parts[5]);
                        int timesToComplete = int.Parse(parts[6]);
                        int bonusPoints = int.Parse(parts[7]);
                        CheckListGoal listGoal = new CheckListGoal();
                        {
                            listGoal.SetGoalCompletion = goalCompletion;
                            listGoal.SetGoalName = goalName;
                            listGoal.SetGoalDescription = goalDescription;
                            listGoal.SetGoalPoints = goalPoints;
                            listGoal.SetTimesToComplete = timesToComplete;
                            listGoal.SetTimesCompleted = timesCompleted;
                            listGoal.SetBonusPoints = bonusPoints;
                            AddGoal(listGoal);

                        }
                        break;

                }
            }



        }
    }
    
    public void GetLevel()
{
    int level = 1;
    int threshold = 99;
    int increment = 150;

    while (_totalScore >= threshold)
    {
        level++;
        threshold += increment;
        increment += 50;
    }
    Console.WriteLine($"You are level: {level}");
}

}