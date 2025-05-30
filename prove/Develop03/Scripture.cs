public class Scripture
{
    private string _text;

    public Scripture(string text)
    {
        _text = text;
    }

    public void DisplayScripture()
    {
        Console.WriteLine(_text);
    }
}