class BreathingActivity : Activity
{
    private string _description;
    private int _rounded;
    public BreathingActivity()
    {
        _description = "This activity will help you relax by walking through your breathing in and out slowly. CLear your mind and focus your breathing.";

    }
    public BreathingActivity(string startMessage, string endMessage, int duration, string description, int rounded)
    : base(startMessage, endMessage, duration)
    {
        _description = description;
        _rounded = rounded;
    }

    public string DisplayActivity()
    {
        Console.WriteLine($"{DisplayStartMessage()} Breathing Activity");
        return $"\n{_description}";
    }

    public void BreatheLength()
    {
        int breatheLength = GetDuration / 8;
        int rounded = (int)Math.Ceiling((double)breatheLength);
        _rounded = rounded + 1;
    }

    public void DisplayBreathingActivity()
    {
        int countdownTime = _rounded;
        int cycles = 4;

        for (int cycle = 0; cycle < cycles; cycle++)
        {
            for (int i = countdownTime; i > 0; i--)
            {
                Console.Write($"Breathe in...{i} \r");
                Thread.Sleep(1000);
            }

            for (int i = countdownTime; i > 0; i--)
            {
                Console.Write($"Breathe out...{i} \r");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }

    }
}