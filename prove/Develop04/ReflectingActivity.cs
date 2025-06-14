class ReflectingActivity : Activity
{
    private string _description;
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
    {
        _description = "This activity will help you reflect on times in you life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life";
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

    }

    public ReflectingActivity(string startMessage, string endMessage, int duration, string description, List<string> prompts, List<string> questions)
    : base(startMessage, endMessage, duration)
    {
        _description = description;
        _prompts = prompts;
        _questions = questions;
    }

    public void DisplayActivity()
    {
        DisplaySpinner();
        Console.WriteLine($"{DisplayStartMessage()} Reflecting Activity");
        Console.WriteLine($"\n{_description}");
        Duration();
        ReflectingLength();
        DisplayReflectingActivity();
        Console.WriteLine(DisplayEndMessage2() + " " + ActivityName());
        Console.WriteLine(DisplayEndMessage1());
        DisplaySpinner();
    }

    public int ReflectingLength()
    {
        return GetDuration;
    }

    public void DisplayReflectingActivity()
    {
        int seconds = ReflectingLength();
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(seconds);
        GetRandomPrompt();
        Console.WriteLine();
        Console.WriteLine("Press enter when you are ready for the questions.");
        Console.WriteLine();
        Console.ReadLine();
        while (DateTime.Now < endTime)
        {
            GetRandomQuestion();
        }
    }

    public void GetRandomPrompt()
    {
        Random rnd = new Random();
        string prompt = _prompts[rnd.Next(_prompts.Count)];
        Console.WriteLine(prompt);
    }

    public void GetRandomQuestion()
    {
        Random random = new Random();
        string question = _questions[random.Next(_questions.Count)];
        Console.Write(question);
        DisplaySpinner();
        Console.WriteLine();

    }

    public string ActivityName()
    {
        return "Reflecting Activity";
    }
}