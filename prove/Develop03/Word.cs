public class Word
{
    private string _word;
    private List<Word> _words = new();
    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    public string Value()
    {
        if (_hidden)
        {
            return new string('_', _word.Length);
        }

        else
        {
            return _word;
        }
    }

    public void Hide()
    {
        _hidden = true;
    }

    public void UnHide()
    {
        _hidden = false;
    }
}