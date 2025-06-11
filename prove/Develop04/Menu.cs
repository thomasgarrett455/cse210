class Menu
{
    public void DisplayMenu()
    {
        string response = "";
        while (response != "4")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\\t 1. Start Breathing Activity");
            Console.WriteLine("\\t 2. Start Reflecting Activity");
            Console.WriteLine("\\t 3. Start Listing Activity");
            Console.WriteLine("\\t 4. Quit");
            response = Console.ReadLine();

            switch (response)
            {
                case "1":
                    BreathingActivity activity = new BreathingActivity();
                    Console.WriteLine(activity.DisplayActivity());
                    break;

                case "2":
                    Console.WriteLine("Starting Reflecting Activity!");
                    break;
                case "3":
                    Console.WriteLine("Start2ing Listing Activity!");
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