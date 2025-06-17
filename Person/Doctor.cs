class Doctor : Person
{

    private string _instuments;
    private double _salary;
    public Doctor(string firstName, string lastName, int age, string instruments, double salary)
    : base(firstName, lastName, age)
    {
        _instuments = instruments;
        _salary = salary;
    }

    public override string GetPersonInformation()
    {

        return $"{base.GetPersonInformation()} :: Instruments: {_instuments}";
    }

    public override double GetSalary()
    {
        return _salary;
    }
}