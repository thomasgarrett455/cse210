class Lecutres : Event
{
    private string _speaker;
    private int _capacity;

    public Lecutres(string eventTitle, string description, string date, string time, Address address, string speaker, int capacity)
    : base(eventTitle, description, date, time, address, "Lectures")
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string FullDetails()
    {
        return $"{base.FullDetails()}Speaker: {_speaker}\nCapacity: {_capacity}";
    }
}