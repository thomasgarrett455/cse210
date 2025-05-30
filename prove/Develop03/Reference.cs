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

     public void DisplayReference()
    {
        if (_startVerse == _endverse)
            Console.WriteLine($"{_scripture} {_chapter}:{_startVerse}");
        else
            Console.WriteLine($"{_scripture} {_chapter}:{_startVerse}-{_endverse}");
    }

}