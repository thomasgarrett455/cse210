class BreathingActivity : Activity
{
    private string _description;
    public BreathingActivity()
    {
        _description = "This activity will help you relax by walking through your breathing in and out slowly. CLear your mind and focus your breathing.";
    }
    public BreathingActivity(string startMessage, string endMessage, int duration, string description)
    : base(startMessage, endMessage, duration)
    {
        _description = description;
    }

    public int DisplayActivity()
    {
        Console.WriteLine($"{DisplayStartMessage()} Breathing Activity");
        Console.WriteLine($"\n{_description}");
        Console.WriteLine("\nHow long, in seconds, would you like your session? ");
        string response = Console.ReadLine();
        int age = int.Parse(response);
        return age;
    }
}