class Menu
{

    private int _activity1;
    private int _activity2;
    private int _activity3;
    public void DisplayMenu()
    {
        string response = "";
        while (response != "4")
        {   
            Console.WriteLine();
            Console.WriteLine($"Breathing Activity performed {_activity1} times.");
            Console.WriteLine($"Reflecting Activity performed {_activity2} times.");
            Console.WriteLine($"Listing Activity performed {_activity3} times");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t 1. Start Breathing Activity");
            Console.WriteLine("\t 2. Start Reflecting Activity");
            Console.WriteLine("\t 3. Start Listing Activity");
            Console.WriteLine("\t 4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            response = Console.ReadLine();

            switch (response)
            {
                case "1":
                    BreathingActivity activity = new BreathingActivity();
                    activity.DisplayActivity();
                    _activity1++;
                    break;

                case "2":
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.DisplayActivity();
                    _activity2++;
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.DisplayActivity();
                    _activity3++;
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine($"{response} is not valid. Please try again.");
                    break;

            }
        }

    }
}