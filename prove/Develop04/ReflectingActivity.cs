class ReflectingActivity : Activity
{
    private string _description;
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
    {
        _description = "This activity will help you reflect on times in you life when you have shown strength and resilience. THis will help you recognize the power you have and how you can use it in other aspects of your life";
        _prompts = new List<string>{
"What was the most meaningful moment of my day, and why?",
"What challenges did I face today, and how did I handle them?",
"Did I show kindness or patience today? In what ways?",
"What did I learn about myself today?",
"What is one thing I could improve on tomorrow?",
"What am I grateful for today?",
"How did I step out of my comfort zone recently?",
"What is something I’ve been avoiding, and why?",
"How have I grown over the past month?",
"If today were my last day, would I be proud of how I lived it? Why or why not?" };

    }

    public ReflectingActivity(string startMessage, string endMessage, int duration, string description, List<string> prompts, List<string> questions)
    : base(startMessage, endMessage, duration)
    {
        _description = description;
        _prompts = prompts;
        _questions = questions;
    }

    public string DisplayActivity()
    {
        Console.WriteLine($"{DisplayStartMessage()} Reflecting Activity");
        return $"\n{_description}";
    }

    public int ReflectingLength()
    {
        return GetDuration;
    }
}