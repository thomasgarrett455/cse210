using System;

class Program
{
    static void Main(string[] args)
    {
        Address myAddress = new Address("123 Street", "Rexburg", "Idaho", "USA");
        Lecutres myLectures = new Lecutres("Overcoming Sales Objections", "Listen to famous and successful speakers in the sales world!", "9/24/25", "11:00AM", myAddress, "David Goggins", 10000);
        Console.WriteLine(myLectures.FullDetails());
        Console.WriteLine();
        Console.WriteLine(myLectures.ShortDescription());
        Console.WriteLine();
        Console.WriteLine(myLectures.StandardDetails());
        Console.WriteLine();

        Address myAddress1 = new Address("321 Ave", "Idaho Falls", "Idaho", "USA");
        Receptions myReceptions = new Receptions("Bill and Jill Wedding Recetpion", "Enjoy the reception of the couple Bill and Jill", "10/24/25", "5:30PM", myAddress1, "BillAndJill@gmail.com");
        Console.WriteLine(myReceptions.FullDetails());
        Console.WriteLine();
        Console.WriteLine(myReceptions.ShortDescription());
        Console.WriteLine();
        Console.WriteLine(myReceptions.StandardDetails());
        Console.WriteLine();

        Address myAddress2 = new Address("543 Boulevard", "Pocatello", "Idaho", "USA");
        Outdoor myOutdoor = new Outdoor("Bonfire", "Come enjoy a bonfire and a shared space among friends", "08/27/25", "8:00PM", myAddress2, "Clear Skies");
        Console.WriteLine(myOutdoor.FullDetails());
        Console.WriteLine();
        Console.WriteLine(myOutdoor.ShortDescription());
        Console.WriteLine();
        Console.WriteLine(myOutdoor.StandardDetails());


    }
}