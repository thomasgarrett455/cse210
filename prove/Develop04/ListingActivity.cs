using System.Runtime.CompilerServices;

class ListingActivity : Activity
{
    private string _description;
    private List<string> _questions;

    public ListingActivity(string startMessage, string endMessage, int duration, string description, List<string> questions)
    : base(startMessage, endMessage, duration)
    {
        _description = description;
        _questions = questions;
    }

    public ListingActivity()
    {
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _questions = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void DisplayActivity()
    {
        DisplaySpinner();
        Console.WriteLine($"{DisplayStartMessage()} Listing Activity");
        Console.WriteLine($"\n{_description}");
        Duration();
        ListingLength();
        DisplayListingActivity();
        int count = GetRandomQuestion();
        Console.WriteLine($"You listed {count} items");
       Console.WriteLine(DisplayEndMessage2() + " " + ActivityName());
        Console.WriteLine(DisplayEndMessage1());
        DisplaySpinner();
    }

    public int ListingLength()
    {
        return GetDuration;
    }

    public void DisplayListingActivity()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Random rnd = new Random();
        string question = _questions[rnd.Next(_questions.Count)];
        Console.WriteLine(question);
    }

    public int GetRandomQuestion()
    {
        int timer = 5;

        DateTime currentTime = DateTime.Now;
        DateTime endTimer = currentTime.AddSeconds(timer);
        DateTime endTime = currentTime.AddSeconds(GetDuration);

        while (DateTime.Now < endTimer)
        {
            Console.Write($"\rYou may begin in: {timer--}");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
        int count = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            Console.ReadLine();
            count++;
        }
        return count;
    } 

    public string ActivityName()
    {
        return "Listing Activity";
    }   
       
}