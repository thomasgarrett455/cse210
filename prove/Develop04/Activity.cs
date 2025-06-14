public class Activity
{
    private string _startMessage;
    private string _endMessage1;
    // private string _endMessage2;
    private int _duration;

    public Activity()
    {
        _startMessage = "Welcome to the ";
        _endMessage1 = "Well done!!";
        _duration = 0;
        // _endMessage2 = $"You have completed another {_duration} seconds of the";
    }

    public Activity(string startMessage, string endMessage1, int duration)
    {
        _startMessage = startMessage;
        _endMessage1 = endMessage1;
        _duration = duration;
    }

    public int GetDuration
    {
        get { return _duration; }
    }

    public string DisplayStartMessage()
    {
        return $"{_startMessage}";
    }

    public string DisplayEndMessage1()
    {
        return $"{_endMessage1}";
    }

    public string DisplayEndMessage2()
    {
        return $"You have completed another {_duration} seconds of the";
    }

    public int Duration()
    {
        Console.WriteLine("How long, in seconds, would you like for your session?");
        string seconds = Console.ReadLine();
        _duration = int.Parse(seconds);
        return _duration;
    }

    public void DisplaySpinner()
    {
        int sleepTime = 200;
        int seconds = 3;

        DateTime cureentTime = DateTime.Now;
        DateTime endTime = cureentTime.AddSeconds(seconds);

        string animation = "|/-|\\-";

        while (DateTime.Now < endTime)
        {
            Console.Write(animation[0]);
            Thread.Sleep(sleepTime);
            Console.Write("\b");
            Console.Write(animation[1]);
            Thread.Sleep(sleepTime);
            Console.Write("\b");
            Console.Write(animation[2]);
            Thread.Sleep(sleepTime);
            Console.Write("\b");
            Console.Write(animation[3]);
            Thread.Sleep(sleepTime);
            Console.Write("\b");
            Console.Write(animation[4]);
            Thread.Sleep(sleepTime);
            Console.Write("\b");
            Console.Write(animation[5]);
            Thread.Sleep(sleepTime);
            Console.Write("\b");
        }
    }
}

