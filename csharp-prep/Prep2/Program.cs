using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int percentage = int.Parse(gradePercentage);
        string letter = "";
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80 && percentage < 90)
        {
            letter = "B";
        }
        else if (percentage >= 70 && percentage < 80)
        {
            letter = "C";
        }
        else if (percentage >= 60 && percentage < 70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"You have a {letter}.");

        string youPassed = "Congrats! You passed the class.";
        if (percentage >= 70)
        {
            Console.WriteLine(youPassed);
        }
        string encourage = "Better luck next time!";
        if (percentage < 70)
        {
            Console.WriteLine(encourage);
        }
    }
}