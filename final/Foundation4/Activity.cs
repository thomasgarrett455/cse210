public abstract class Activity
{
    private string _date;
    private int _length;
    private string _activityType;
    private double _speed;
    private double _pace;


    public Activity(string date, int length, string activitytype)
    {
        _date = date;
        _length = length;
        _activityType = activitytype;
        _speed = 0;
        _pace = 0;
    }

    public string GetDate()
    {
        return _date;
    }

    public int GetLength()
    {
        return _length;
    }

    public string GetActivityType()
    {
        return _activityType;
    }

    public virtual string ActivityInfo()
    {
        return $"{GetDate()} {GetActivityType()} ({GetLength()}min)-";
    }

    public abstract double GetPace();

}