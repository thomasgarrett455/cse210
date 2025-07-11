using System;

class Program
{
    static void Main(string[] args)
    {
        Running myRunning = new Running("03 Nov 2025", 60, 5);

        Bike myBike = new Bike("03 Nov 2025", 60, 10);

        Swim mySwim = new Swim("03 Nov 2025", 30, 20);

        List<Activity> myEvents = new List<Activity>();
        myEvents.Add(myRunning);
        myEvents.Add(myBike);
        myEvents.Add(mySwim);

        foreach (Activity activity in myEvents)
        {
            DisplayActivityInformation(activity);
            Console.WriteLine();
        }
    }

    public static void DisplayActivityInformation(Activity activity)
    {
        Console.WriteLine(activity.ActivityInfo());
    }
}