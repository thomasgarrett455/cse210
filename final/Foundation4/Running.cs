class Running : Activity
{
    private double _distance;
    public Running(string date, int length, double distance)
    : base(date, length, "Running")
    {
        _distance = distance;
    }

    public override string ActivityInfo()
    {
        return $"{base.ActivityInfo()} Distance: {_distance} miles, Speed: {GetSpeed()}mph, Pace: {GetPace()} min per mile";
    }

    public double GetSpeed()
    {
        return _distance / GetLength() * 60;
    }

    public override double GetPace()
    {
        return GetLength() / _distance;
    }


    
}