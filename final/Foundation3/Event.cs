class Event
{
    private string _eventTitle;
    private string _descritpion;
    private string _date;
    private string _time;
    private Address _address;
    private string _eventType;

    public Event(string eventTitle, string description, string date, string time, Address address, string eventType)
    {
        _eventTitle = eventTitle;
        _descritpion = description;
        _date = date;
        _time = time;
        _address = address;
        _eventType = eventType;
    }

    public string StandardDetails()
    {
        return $"Event Title: {_eventTitle}\nDescription: {_descritpion}\nDate: {_date}\nTime: {_time}\nAddress: {_address.DisplayAddress()}";
    }

    public string ShortDescription()
    {
        return $"Event type: {GetEventtype()}\nTitle: {GetTitle()}\nDate: {GetDate()}";
    }

    public virtual string FullDetails()
    {
        return $"{StandardDetails()}\n";
    }

    public string GetTitle()
    {
        return _eventTitle;
    }

    public string GetDate()
    {
        return _date;
    }

    public string GetEventtype()
    {
        return _eventType;
    }

}