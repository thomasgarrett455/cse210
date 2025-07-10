class Videos
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comments> _comments;

    public Videos(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comments>();
    }

    public void AddComment(Comments comment)
    {
        _comments.Add(comment);
    }

    public List<Comments> GetComments()
    {
        return _comments;
    }

    public string DisplayVideoInfo()
    {
        string info = $"Video Name: {_title}, Author: {_author}, Length: {_length}, Number of comments: {NumberOfComments()}\n";
        info += "Comments:\n";

        foreach (var comment in _comments)
        {
            info += $"- {comment.GetName()}: {comment.GetText()}\n";
        }
        return info;
    }

    public int NumberOfComments()
    {
        int count = _comments.Count;
        return count;
    }
}