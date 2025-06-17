class Program
{
    public static void Main(string[] args)
    {
        // Person myPerson = new Person("Bubba", "Bob", 32);
        // Console.WriteLine(myPerson.GetPersonInformation());

        PoliceMan myPoliceMan = new PoliceMan("Cooper", "Silver", 42, "Club", 40, 60);
        // Console.WriteLine(myPoliceMan.GetPoliceManInformation());

        Doctor myDoctor = new Doctor("Abdul", "Abundi", 47, "Stethascope", 450000);
        // Console.WriteLine(myDoctor.GetDoctorInformation());

        List<Person> myPeople = new List<Person>();
        // myPeople.Add(myPerson);
        myPeople.Add(myDoctor);
        myPeople.Add(myPoliceMan);

        foreach (Person person in myPeople)
        {
            DisplayPersonInformation(person);
        }
    }

    private static void DisplayPersonInformation(Person person)
    {
        Console.Write(person.GetPersonInformation());
        Console.WriteLine($" Salary: {person.GetSalary()}");
    }

}
