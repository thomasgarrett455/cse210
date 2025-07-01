using System.Runtime.InteropServices;

class Menu
{
    GoalManager manager = new GoalManager();

    public void DisplayMenu()
    {
        string response = "";
        while (response != "6")
        {
            manager.DisplayScore();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Select a choice from the menu: ");

            response = Console.ReadLine();

            switch (response)
            {
                case "1":

                    Console.WriteLine("The types of goals are:");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.WriteLine("Which type of goal would you like to create? ");
                    string userInput = Console.ReadLine();
                    switch (userInput)
                    {
                        default:
                            Console.WriteLine($"{userInput} is not valid. Try again");
                            break;
                        case "1":
                            Console.WriteLine("You have chosen Simple Goal");
                            SimpleGoal simpleGoal = new SimpleGoal();
                            simpleGoal.GoalInformation();
                            manager.AddGoal(simpleGoal);
                            break;
                        case "2":
                            Console.WriteLine("You have chosen Eternal Goal");
                            EternalGoal eternalGoal = new EternalGoal();
                            eternalGoal.GoalInformation();
                            manager.AddGoal(eternalGoal);
                            break;
                        case "3":
                            Console.WriteLine("You have chosen Checklist Goal");
                            CheckListGoal checkListGoal = new CheckListGoal();
                            checkListGoal.GoalInformation();
                            manager.AddGoal(checkListGoal);
                            break;
                    }
                    break;

                case "2":
                    Console.WriteLine("You have selected to list goals.");
                    manager.DisplayAllGoals();
                    break;

                case "3":
                    Console.WriteLine("You have selected to save goals.");
                    manager.SaveToFile();
                    break;

                case "4":
                    Console.WriteLine("You have selected to load goals.");
                    manager.LoadFromFile();
                    break;

                case "5":
                    Console.WriteLine("You have selected to record event.");
                    manager.RecordEvent();
                    break;

                case "6":
                    Console.WriteLine("You have selected to exit.");
                    break;

                default:
                    Console.WriteLine($"{response} is not valid. Please try again.");
                    break;

            }
        }
    }
}