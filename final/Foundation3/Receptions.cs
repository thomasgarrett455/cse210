class Receptions : Event
{
    private string _email;

    public Receptions(string eventTitle, string description, string date, string time, Address address, string email)
    : base(eventTitle, description, date, time, address, "Reception")
    {
        _email = email;
    }


    public override string FullDetails()
    {
        return $"{base.FullDetails()}Email for RSVP: {_email}";
    }
}