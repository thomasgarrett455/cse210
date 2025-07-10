class Bike : Activity
{
    private double _speed;

    public Bike(string date, int length, double speed)
    : base(date, length, "Cycling")
    {
        _speed = speed;
    }

    public double GetDistance()
    {
        return _speed * GetLength() / 60;
    }

    public override double GetPace()
    {
        return GetLength() / GetDistance();
    }

    public override string ActivityInfo()
    {
        return $"{base.ActivityInfo()} Distance: {GetDistance()} miles, Speed: {_speed}mph, Pace: {GetPace()} min per mile";
    }
}