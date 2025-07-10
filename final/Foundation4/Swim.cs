class Swim : Activity
{
    private double _laps;

    public Swim(string date, int length, double laps)
    : base(date, length, "Swimming")
    {
        _laps = laps;
    }

    public double GetDistance()
    {
        return _laps * 50 / 1609.344;
    }

    public override double GetPace()
    {
        return GetLength() / GetDistance();
    }

    public double GetSpeed()
    {
        return GetDistance() / GetLength() * 60;
    }

    public override string ActivityInfo()
    {
        return $"{base.ActivityInfo()} Distance: {GetDistance():F2} miles, Speed: {GetSpeed():F2}mph, Pace: {GetPace():F2} min per mile";
    }
}