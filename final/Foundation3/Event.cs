public abstract class Event
{
    private string _eventTitle;
    private string _descritpion;
    private string _date;
    private string _time;
    private string _address;

    public Event(string eventTitle, string description, string date, string time, string address)
    {
        _eventTitle = eventTitle;
        _descritpion = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string StandardDetails()
    {
        return $"{_eventTitle}, {_descritpion}, {_date}, {_time}, {_address}";
    }

    public abstract string FullDetails();

    public abstract string ShortDescription();
}