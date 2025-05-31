public class Reference
{

    private string _scripture;
    private int _chapter;
    private int _startVerse;
    private int _endverse;

    public Reference(string scripture, int chapter, int startVerse, int endVerse)
    {
        _scripture = scripture;
        _chapter = chapter;
        _startVerse = startVerse;
        _endverse = endVerse;
    }

    public Reference(string scripture, int chapter, int startVerse)
    {
        _scripture = scripture;
        _chapter = chapter;
        _startVerse = startVerse;
    }

     public void DisplayReference()
    {
        Console.WriteLine($"{_scripture} {_chapter}:{_startVerse}{(_endverse > 0 && _startVerse != _endverse ? $"-{_endverse}" : "")}");
    }

}