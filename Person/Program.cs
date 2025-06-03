class Program
{
    public static void Main(string[] args)
    {
        Person myPerson = new Person("Bubba", "Bob", 32);
        Console.WriteLine(myPerson.GetPersonInformation());

        PoliceMan myPoliceMan = new PoliceMan("Cooper", "Silver", 42, "Club");
        Console.WriteLine(myPoliceMan.GetPersonInformation());
    }
}
