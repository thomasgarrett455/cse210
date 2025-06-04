using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment myMathAssignment = new MathAssignment("Bob", "Math", "Sectiob 7.3", "8-19");
        Console.WriteLine(myMathAssignment.GetSummary());
        Console.WriteLine(myMathAssignment.GetHomeWorkList());

        WritingAssignment myWritingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(myWritingAssignment.GetSummary());
        Console.WriteLine(myWritingAssignment.GetWritingInformation());
    }
}