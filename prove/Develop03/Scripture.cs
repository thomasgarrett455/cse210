public class Scripture
{
    private string _text;
    private List<Word> _words;


    public Scripture(string text)
    {
        _text = text;
        _words = text.Split(" ").Select(word => new Word(word)).ToList();
    }

    public void Hide3()
    {
        Random rand = new Random();
        int index1 = rand.Next(_words.Count);
        int index2 = rand.Next(_words.Count);
        int index3 = rand.Next(_words.Count);
        _words[index1].Hide();
        _words[index2].Hide();
        _words[index3].Hide();

    }

    public void UnHide3()
    {
        Random rand = new Random();
        int index1 = rand.Next(_words.Count);
        int index2 = rand.Next(_words.Count);
        int index3 = rand.Next(_words.Count);
        _words[index1].UnHide();
        _words[index2].UnHide();
        _words[index3].UnHide();
    }

    public void DisplayScripture()
    {
        string newText = string.Join(" ", _words.Select(word => word.Value()));

        Console.WriteLine(newText);
    }

    
}