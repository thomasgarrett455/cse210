using System;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        // CheckListGoal MYgoal = new CheckListGoal("Clean", "Dust fans", 10, 3, 0, 100);
        // Console.WriteLine(MYgoal.GetGoalPoints());
        // Console.WriteLine(MYgoal.GetGoalCompletions());
        // Console.WriteLine(MYgoal.RecordEvent());
        // Console.WriteLine(MYgoal.RecordEvent());
        // Console.WriteLine(MYgoal.GetGoalInformation());

        // Menu myMenu = new Menu();
        // myMenu.DisplayMenu();

        SimpleGoal goal = new SimpleGoal("Clean", "Dust fans", 10, false);
        Console.WriteLine(goal.RecordEvent());
        Console.WriteLine(goal.GetGoalInformation());




    }
}