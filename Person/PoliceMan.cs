class PoliceMan : Person
{

    private string _weapons;
    public PoliceMan(string firstName, string lastName, int age, string weapons)
    : base(firstName, lastName, age)
    {
        _weapons = weapons;
    }

        public override string GetPersonInformation()
    {
        // Extend base method and add weapon info
        return base.GetPersonInformation() + $" Weapon: {_weapons}";
    }
}