using System;

class Program
{
    static void Main(string[] args)
    {
        Goals myGoal = new Goals("Goal", "Description", 50);
        Console.WriteLine(myGoal.GetGoalName());
    }
}