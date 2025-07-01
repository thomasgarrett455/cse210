
class Program
{
    static void Main(string[] args)
    {
        // Menu myMenu = new Menu();
        // myMenu.DisplayMenu();

        // SimpleGoal simplegoal = new SimpleGoal("Clean", "Dust fans", 10);
        // simplegoal.RecordEvent();
        // Console.WriteLine(simplegoal.DisplayGoalInformation());

        CheckListGoal checkgoal = new CheckListGoal("Clean", "Dust Fans", 10, 5, 0, 100);
        Console.WriteLine(checkgoal.RecordEvent());
        Console.WriteLine(checkgoal.GetPoints());
        // checkgoal.RecordEvent();
        // checkgoal.RecordEvent();
        // checkgoal.RecordEvent();
        // checkgoal.RecordEvent();


        // Console.WriteLine(checkgoal.DisplayGoalInformation());

        // EternalGoal eternalgoal = new EternalGoal("Clean", "Dust Fans", 10);
        // eternalgoal.RecordEvent();
        // Console.WriteLine(eternalgoal.DisplayGoalInformation());

        // List<Goals> myGoals = new List<Goals>();
        // myGoals.Add(simplegoal);
        // myGoals.Add(checkgoal);
        // myGoals.Add(eternalgoal);

        // foreach (Goals goal in myGoals)
        // {
        //     DisplayGoalInformation(goal);
        // }
    }
            // private static void DisplayGoalInformation(Goals goal)
            // {
            // Console.WriteLine(goal.DisplayGoalInformation());
            // }

}