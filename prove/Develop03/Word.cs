public class Word
{
    private string _word;
    private List<Word> _words = new();
    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    public string Value()
    {
        if (_isHidden)
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
        _isHidden = true;
    }

    public void UnHide()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
}