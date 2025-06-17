class PoliceMan : Person
{

    private string _weapons;
    private double _hourlyWage;
    private int _hoursWorked;
    public PoliceMan(string firstName, string lastName, int age, string weapons, int hoursWorked, double hourlyWage)
    : base(firstName, lastName, age)
    {
        _weapons = weapons;
        _hourlyWage = hourlyWage;
        _hoursWorked = hoursWorked;
    }

    public override string GetPersonInformation()
    {

        return $"{base.GetPersonInformation()} :: Wepons: {_weapons}";
    }

    public override double GetSalary()
    {
        double pay = _hoursWorked * _hourlyWage;
        if (_hoursWorked > 40)
        {
            pay += (_hoursWorked - 40) * _hourlyWage * 2;
        }
        return pay;
    }
}