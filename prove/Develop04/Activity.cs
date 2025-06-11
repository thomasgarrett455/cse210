public class Activity
{
    private string _startMessage;
    private string _endMessage;
    private int _duration;

    public Activity()
    {
        _startMessage = "Welcome to the ";
        _endMessage = "";
        _duration = 0;
    }

    public Activity(string startMessage, string endMessage, int duration)
    {
        _startMessage = startMessage;
        _endMessage = endMessage;
        _duration = duration;
    }

    public string DisplayStartMessage()
    {
        return $"{_startMessage}";
    }
}