// class CheckListGoal : Goals
// {
//     private int _timesToComplete;
//     private int _timesCompleted;
//     private int _bonusPoints;

//     public CheckListGoal()
//     {
//         _timesCompleted = 0;
//         _timesToComplete = 0;
//         _bonusPoints = 0;
//     }
//     public CheckListGoal(string goalName, string goalDescription, int goalPoints, bool isCompleted, int timesToComplete, int timesCompleted, int bonusPoints)
//     : base(goalName, goalDescription, goalPoints, isCompleted)
//     {
//         _timesToComplete = timesToComplete;
//         _timesCompleted = timesCompleted;
//         _bonusPoints = bonusPoints;
//     }

//     public override bool IsGoalComplete()
//     {
//         return _timesCompleted >= _timesToComplete;
//     }

//     public override int RecordEvent()
//     {
//         Console.WriteLine($"Recording Event: {_timesCompleted + 1}/{_timesToComplete}");
//         if (_timesCompleted < _timesToComplete)
//         {
//             _timesCompleted++;
//             if (_timesCompleted == _timesToComplete)
//             {
//                 return GetGoalPoints() + _bonusPoints;
//             }
//             else
//             {
//                 return GetGoalPoints();
//             }
//         }
//         return 0;
//     }

//     public string GetGoalCompletions()
//     {
//         return $"{_timesCompleted} / {_timesToComplete}";
//     }
//     public override (string, int) GetGoalInformation()
//     {
//        var (baseInfo, basePoints) = base.GetGoalInformation();
//         Console.WriteLine("How many time to complete this goal? ");
//         string times = Console.ReadLine();
//         _timesToComplete = int.Parse(times);

//         Console.WriteLine("How many Bonus Points for completing this goal? ");
//         string bonus = Console.ReadLine();
//         _bonusPoints = int.Parse(bonus);

//         string updatedInfo = $"{baseInfo} | Completion: {_timesCompleted} / {_timesToComplete} | Bonus: {_bonusPoints}";
//           return (updatedInfo, basePoints);
//     }
// }


