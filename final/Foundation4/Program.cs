using System;

class Program
{
    static void Main(string[] args)
    {
        Running myRunning = new Running("03 Nov 2025", 60, 5);
        Console.WriteLine(myRunning.ActivityInfo());
        Console.WriteLine();

        Bike myBike = new Bike("03 Nov 2025", 60, 10);
        Console.WriteLine(myBike.ActivityInfo());
        Console.WriteLine();

        Swim mySwim = new Swim("03 Nov 2025", 30, 20);
        Console.WriteLine(mySwim.ActivityInfo());
        
    }
}