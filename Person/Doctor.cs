class Doctor : Person
{

    private string _instuments;
    public Doctor(string firstName, string lastName, int age, string instruments)
    : base(firstName, lastName, age)
    {
        _instuments = instruments;
    }

        public string GetDoctorInformation()
    {

        return $"{GetPersonInformation()} :: Instruments: {_instuments}";
    }
}