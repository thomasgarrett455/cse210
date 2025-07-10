class Outdoor : Event
{
    private string _weather;

    public Outdoor(string eventTitle, string description, string date, string time, Address address, string weather)
    : base(eventTitle, description, date, time, address, "Outdoor Gathering")
    {
        _weather = weather;
    }

    public override string FullDetails()
    {
        return $"{base.FullDetails()}Weather: {_weather}";
    }
    
}